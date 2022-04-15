

//chart.js - ReportOne: 
$(function(){  
    //$(".json") = console.log(JsonCategories());
    // $('#reportTwo').remove();
    // $('#chart_container').append('<canvas id="reportTwo"></canvas>');  
    var reportOneLabels = [ ];

    $.getJSON({
        url: "../../api/category/2/product/discontinued/false",
        success: function (response, textStatus, jqXhr) {
            // console.log(response);
            for (var i = 0; i < response.length; i++){
                reportOneLabels.push(response[i].productName);
            }
            //console.log(reportOneLabels);
            generateChartOne();
        },
        error: function (jqXHR, textStatus, errorThrown) {
            // log the error to the console
            console.log("The following error occured: " + textStatus, errorThrown);
        }
    });    
    function generateChartOne(){
        const ctx1 = document.getElementById('reportOne');
reportOne = new Chart(ctx1, {
    type: 'bar',
    data: {
        labels: reportOneLabels,
        
        datasets: [{
            label: 'Average Temperature',
            backgroundColor: ['gray','red','green','yellow','orange','pink'],
            borderColor: 'black',
            borderWidth:1,
            hoverBorderWidth:3,
            hoverBorderColor:'black',
            data: [5, 2, 25, 35, 55, 70, 75],          
            title: { display: true, text: 'DEMO CHART' },  
            legend: { position: 'bottom' },
        }]        
    },
    options: {
        plugins: {
            title:{
                display: true,
                text:'Link db item name here',
                font: {
                    size: 25
                },
                padding: {
                    top: 30,
                    bottom: 30
                }
            },
            legend:{
                    labels: {
                        // This more specific font property overrides the global property
                        font: {
                            size: 15
                        },                         
                    padding: 50  
                    },
                    position:'bottom',
                    fontColor:'black',
                    label: 'Average Temperature',  
            },
                                   
        }
        
    }
})
    }
});//chart.js - ReportTwo: 
$(function(){    
    // $('#reportOne').remove();
    // $('#chart_container').append('<canvas id="reportOne"></canvas>');
    const ctx2 = document.getElementById('reportTwo');
    reportTwo = new Chart(ctx2, {
        // let reportOne = document.getElementById('reportOne').getContext('2d');
        // let NewChart = new Chart(reportOne, {
        type: 'line',
        data: {
            labels: [
                'January',
                'February',
                'March',
                'April',
                'May',
                'June',
            ],
            
            datasets: [{
                label: 'Average Temperature',
                backgroundColor: ['gray','red','green','yellow','orange','pink'],
                borderColor: 'black',
                borderWidth:1,
                hoverBorderWidth:3,
                hoverBorderColor:'black',
                data: [5, 2, 25, 35, 55, 70, 75],          
                title: { display: true, text: 'DEMO CHART' },  
                legend: { position: 'bottom' },
            }]        
        },
        options: {
            plugins: {
                title:{
                    display: true,
                    text:'Link db item name here',
                    font: {
                        size: 25
                    },
                    padding: {
                        top: 30,
                        bottom: 30
                    }
                },
                legend:{
                        labels: {
                            // This more specific font property overrides the global property
                            font: {
                                size: 15
                            },                         
                        padding: 50  
                        },
                        position:'bottom',
                        fontColor:'black',
                        label: 'Average Temperature',  
                },
                                    
            }
            
        }
    })
});

