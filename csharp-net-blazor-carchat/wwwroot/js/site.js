// Initialize all alerts
document.addEventListener('DOMContentLoaded', function () {
    var alerts = [].slice.call(document.querySelectorAll('.alert'))
    alerts.map(function (element) {
        return new bootstrap.Alert(element)
    })
}); 

function scrollToElement(elementId) {
    const element = document.getElementById(elementId);
    if (element) {
        element.scrollIntoView({ behavior: 'smooth', block: 'start' });
    }
} 