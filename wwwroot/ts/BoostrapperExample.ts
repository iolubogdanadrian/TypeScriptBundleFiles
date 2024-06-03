import { UserFilter } from "./Services/UserFilter.js";

class BoostrapperExample {

    constructor() {
        let userFilter = new UserFilter();

        userFilter.showMessage();
        userFilter.showUser();
    }
}

new BoostrapperExample();