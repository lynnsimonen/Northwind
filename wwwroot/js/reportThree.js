$(function () {

var revenue = [1.11, 2.45, 12345.6]

for (var i = 0; i < revenue.length; i++) {

    const dollars = new Intl.NumberFormat('en-US', {
        style: 'currency',
        currency: 'USD',
        minimumFractionDigits: 2,
    }).format(response[i].revenue);

    $(".i").reportThreeRevenue.push(dollars);
}
});