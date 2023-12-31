import {CORE_CONCEPTS} from "./data.js"
import {Header} from "./components/Header.jsx"
import {CoreConcept} from "./components/CoreConcept.jsx"
import TabButton from "./components/TabButton.jsx"
import { useState } from "react";
import { EXAMPLES } from "./data.js";

function App() {
  const [val, setVal] = useState();

  var tabContent = (<h1>Please select any tab.</h1>)
  if(val){
    tabContent = (<div id="tab-content">
    <h3>{EXAMPLES[val].title}</h3>
    <p>{EXAMPLES[val].description}</p>
    <pre>
      <code>
        {EXAMPLES[val].code}
      </code>
    </pre>
  </div>);
  }

  function clickHandler(type){
    setVal(type)
  }
  return (
    <div>
    <Header />
      <main>
        <section id="core-concepts">
          <h2>Time to get started!</h2>
          <ul>
            {CORE_CONCEPTS.map((coreItem) => <CoreConcept key={coreItem.title} {...coreItem} />)}
          </ul>
        </section>
        <section id="examples">
          <h2>Examples!</h2>
          <menu>
            <TabButton isSelected={val === "components"} clickHandler={() => clickHandler("components")}>Components</TabButton>
            <TabButton isSelected={val === "jsx"} clickHandler={() => clickHandler("jsx")}>JSX</TabButton>
            <TabButton isSelected={val === "props"} clickHandler={() => clickHandler("props")}>Props</TabButton>
            <TabButton isSelected={val === "state"} clickHandler={() => clickHandler("state")}>State</TabButton>
          </menu>
          {tabContent}
        </section>
      </main>
    </div>
  );
}

export default App;
