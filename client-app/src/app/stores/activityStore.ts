import { observable } from "mobx";
import { createContext } from "react";

class ActivityStore {
  @observable title: string = "Hello from mobx";
}

export default createContext(new ActivityStore());
