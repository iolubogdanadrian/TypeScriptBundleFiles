class BoostrapperExample {
    constructor() {
        let userFilter = new FilterUsers();
        userFilter.showMessage();
        userFilter.showUser();
    }
}
class FilterUsers extends Filter {
    showUser() {
        console.log("User Filter");
    }
}
class Filter {
    showMessage() {
        console.log("Filter class");
    }
}
//# sourceMappingURL=tsc.js.map