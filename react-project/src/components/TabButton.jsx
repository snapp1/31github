export default function TabButton({children, clickHandler}){
    return (
    <li>
        <button onClick={clickHandler}>{children}</button>
    </li>
    );
}
