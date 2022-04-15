//chart.js - ReportOne: 
$(function () {
    //$(".json") = console.log(JsonCategories());
    // $('#reportTwo').remove();
    // $('#chart_container').append('<canvas id="reportTwo"></canvas>');  
    var reportOneLabels = [];
    var reportOneData = [];
    var chartTitle;
   

    $.getJSON({
        url: "../../api/category/2/product/discontinued/false",
        url: "../../api/category",
        success: function (response, textStatus, jqXhr) {
            // console.log(response);
            for (var i = 0; i < response.length; i++) {
                reportOneLabels.push(response[i].productName);
            }
            //console.log(reportOneLabels);
            for (var i = 0; i < response.length; i++) {
                reportOneData.push(response[i].unitsInStock);
            }
            chartTitle = categoryName;
            generateChartOne();
        },
        error: function (jqXHR, textStatus, errorThrown) {
            // log the error to the console
            console.log("The following error occured: " + textStatus, errorThrown);
        }
    });
    function generateChartOne() {
        const ctx1 = document.getElementById('reportOne');
        reportOne = new Chart(ctx1, {
            type: 'bar',
            data: {
                labels: reportOneLabels,

                datasets: [{
                    label: 'Product Names',
                    backgroundColor: 'red',
                    borderColor: 'black',
                    borderWidth: 1,
                    hoverBorderWidth: 3,
                    hoverBorderColor: 'black',
                    // data: reportOneData,
                    // title: { display: true, text: 'DEMO CHART' },
                    // legend: { position: 'bottom' },
                }]
            },
            options: {
                plugins: {
                    title: {
                        display: true,
                        text: chartTitle,
                        font: {
                            size: 25
                        },
                        padding: {
                            top: 30,
                            bottom: 30
                        }
                    },
                    legend: {
                        labels: {
                            // This more specific font property overrides the global property
                            font: {
                                size: 15
                            },
                            padding: 50
                        },
                        position: 'bottom',
                        fontColor: 'red',
                        label: 'Quantities in Stock',
                    },

                }

            }
        })
    }
});
