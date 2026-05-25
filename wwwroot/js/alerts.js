window.showAlert = (message) => {
    Swal.fire({
        icon: 'warning',
        title: 'Validation Error',
        text: message,
        width: '350px',
        padding: '1.5rem',
        confirmButtonColor: '#2563eb',
        customClass: {
            popup: 'small-alert',
            title: 'small-alert-title',
            htmlContainer: 'small-alert-text'
        }
    });
}

window.showSuccess = (message) => {
    Swal.fire({
        icon: 'success',
        title: 'Success',
        text: message,
        width: '350px',
        padding: '1.5rem',
        confirmButtonColor: '#16a34a',
        customClass: {
            popup: 'small-alert',
            title: 'small-alert-title',
            htmlContainer: 'small-alert-text'
        }
    });
}