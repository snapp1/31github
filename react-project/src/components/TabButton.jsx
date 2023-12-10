export default function TabButton({children, clickHandler, isSelected}){
    return (
    <li>
        <button className={isSelected ? "active" : ""} onClick={clickHandler}>{children}</button>
    </li>
    );
}
