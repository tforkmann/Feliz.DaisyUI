namespace Feliz.DaisyUI

open Feliz
open Fable.Core

module Helpers =
    let [<Literal>] private ClassName = "className"

    let inline internal getClasses (xs:IReactProperty list) =
        xs
        |> List.choose (unbox<string * obj> >> function
            | (k, v) when k = ClassName -> Some (string v)
            | _ -> None)

    let extractClasses (xs:IReactProperty list) =
        xs
        |> List.rev
        |> List.fold (fun (classes, props) x ->
            match unbox<string * obj> x with
            | (k, v) when k = ClassName -> string v :: classes, props
            | _ -> classes, x :: props) ([], [])

    let combineClasses cn (xs:IReactProperty list) =
        xs
        |> extractClasses
        |> fun (classes, props) -> (cn :: classes |> prop.classes) :: props

    module Elm =
        let inline props buildFn (xs:IReactProperty list) (cn:string) = buildFn (combineClasses cn xs)
        let inline children buildFn (children:seq<ReactElement>) (cn:string) = buildFn [ prop.className cn; prop.children children ]
        let inline elm buildFn (child:ReactElement) (cn:string) = buildFn [ prop.className cn; prop.children [ child ] ]
        let inline string buildFn (value:string) (cn:string) = buildFn [ prop.className cn; prop.text value ]
        let inline int buildFn (value:int) (cn:string) = buildFn [ prop.className cn; prop.text value ]
        let inline float buildFn (value:float) (cn:string) = buildFn [ prop.className cn; prop.text value ]

[<Erase>]
type Daisy =
    static member inline alert props = Helpers.Elm.props Html.div props "alert"
    static member inline alert (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "alert"
    static member inline alert elm = Helpers.Elm.elm Html.div elm "alert"
    static member inline alert string = Helpers.Elm.string Html.div string "alert"
    static member inline alert int = Helpers.Elm.int Html.div int "alert"
    static member inline alert float = Helpers.Elm.float Html.div float "alert"

    static member inline artboard props = Helpers.Elm.props Html.div props "artboard"
    static member inline artboard (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "artboard"
    static member inline artboard elm = Helpers.Elm.elm Html.div elm "artboard"
    static member inline artboard string = Helpers.Elm.string Html.div string "artboard"
    static member inline artboard int = Helpers.Elm.int Html.div int "artboard"
    static member inline artboard float = Helpers.Elm.float Html.div float "artboard"

    static member inline avatar props = Helpers.Elm.props Html.div props "avatar"
    static member inline avatar (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "avatar"
    static member inline avatar elm = Helpers.Elm.elm Html.div elm "avatar"

    static member inline avatarGroup props = Helpers.Elm.props Html.div props "avatar-group"
    static member inline avatarGroup (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "avatar-group"
    static member inline avatarGroup elm = Helpers.Elm.elm Html.div elm "avatar-group"

    static member inline badge props = Helpers.Elm.props Html.div props "badge"
    static member inline badge (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "badge"
    static member inline badge elm = Helpers.Elm.elm Html.div elm "badge"
    static member inline badge string = Helpers.Elm.string Html.div string "badge"
    static member inline badge int = Helpers.Elm.int Html.div int "badge"
    static member inline badge float = Helpers.Elm.float Html.div float "badge"

    static member inline breadcrumbs props = Helpers.Elm.props Html.div props "breadcrumbs"
    static member inline breadcrumbs (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "breadcrumbs"
    static member inline breadcrumbs elm = Helpers.Elm.elm Html.div elm "breadcrumbs"
    static member inline breadcrumbs string = Helpers.Elm.string Html.div string "breadcrumbs"
    static member inline breadcrumbs int = Helpers.Elm.int Html.div int "breadcrumbs"
    static member inline breadcrumbs float = Helpers.Elm.float Html.div float "breadcrumbs"

    static member inline buttonGroup props = Helpers.Elm.props Html.div props "btn-group"
    static member inline buttonGroup (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "btn-group"
    static member inline buttonGroup elm = Helpers.Elm.elm Html.div elm "btn-group"
    static member inline buttonGroup string = Helpers.Elm.string Html.div string "btn-group"
    static member inline buttonGroup int = Helpers.Elm.int Html.div int "btn-group"
    static member inline buttonGroup float = Helpers.Elm.float Html.div float "btn-group"

    static member inline card props = Helpers.Elm.props Html.div props "card"
    static member inline card (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "card"
    static member inline card elm = Helpers.Elm.elm Html.div elm "card"

    static member inline cardTitle props = Helpers.Elm.props Html.h2 props "card-title"
    static member inline cardTitle (children: #seq<ReactElement>) = Helpers.Elm.children Html.h2 children "card-title"
    static member inline cardTitle elm = Helpers.Elm.elm Html.h2 elm "card-title"
    static member inline cardTitle string = Helpers.Elm.string Html.h2 string "card-title"
    static member inline cardTitle int = Helpers.Elm.int Html.h2 int "card-title"
    static member inline cardTitle float = Helpers.Elm.float Html.h2 float "card-title"

    static member inline cardBody props = Helpers.Elm.props Html.div props "card-body"
    static member inline cardBody (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "card-body"
    static member inline cardBody elm = Helpers.Elm.elm Html.div elm "card-body"

    static member inline cardActions props = Helpers.Elm.props Html.div props "card-actions"
    static member inline cardActions (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "card-actions"
    static member inline cardActions elm = Helpers.Elm.elm Html.div elm "card-actions"

    static member inline carousel props = Helpers.Elm.props Html.div props "carousel"
    static member inline carousel (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "carousel"
    static member inline carousel elm = Helpers.Elm.elm Html.div elm "carousel"

    static member inline carouselItem props = Helpers.Elm.props Html.div props "carousel-item"
    static member inline carouselItem (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "carousel-item"
    static member inline carouselItem elm = Helpers.Elm.elm Html.div elm "carousel-item"

    static member inline collapse props = Helpers.Elm.props Html.div props "collapse"
    static member inline collapse (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "collapse"
    static member inline collapse elm = Helpers.Elm.elm Html.div elm "collapse"

    static member inline collapseTitle props = Helpers.Elm.props Html.div props "collapse-title"
    static member inline collapseTitle (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "collapse-title"
    static member inline collapseTitle elm = Helpers.Elm.elm Html.div elm "collapse-title"
    static member inline collapseTitle string = Helpers.Elm.string Html.div string "collapse-title"
    static member inline collapseTitle int = Helpers.Elm.int Html.div int "collapse-title"
    static member inline collapseTitle float = Helpers.Elm.float Html.div float "collapse-title"

    static member inline collapseContent props = Helpers.Elm.props Html.div props "collapse-content"
    static member inline collapseContent (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "collapse-content"
    static member inline collapseContent elm = Helpers.Elm.elm Html.div elm "collapse-content"
    static member inline collapseContent string = Helpers.Elm.string Html.div string "collapse-content"
    static member inline collapseContent int = Helpers.Elm.int Html.div int "collapse-content"
    static member inline collapseContent float = Helpers.Elm.float Html.div float "collapse-content"

    static member inline countdown props = Helpers.Elm.props Html.span props "countdown"
    static member inline countdown (children: #seq<ReactElement>) = Helpers.Elm.children Html.span children "countdown"
    static member inline countdown elm = Helpers.Elm.elm Html.span elm "countdown"

    static member inline countdownValue (value: int) = Html.span [prop.style [style.custom("--value", value)]]

    static member inline divider props = Helpers.Elm.props Html.div props "divider"
    static member inline divider (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "divider"
    static member inline divider elm = Helpers.Elm.elm Html.div elm "divider"
    static member inline divider string = Helpers.Elm.string Html.div string "divider"
    static member inline divider int = Helpers.Elm.int Html.div int "divider"
    static member inline divider float = Helpers.Elm.float Html.div float "divider"

    static member inline drawer props = Helpers.Elm.props Html.div props "drawer"
    static member inline drawer (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "drawer"
    static member inline drawer elm = Helpers.Elm.elm Html.div elm "drawer"

    static member inline drawerToggle props = Helpers.Elm.props Html.input (prop.type'.checkbox :: props) "drawer-toggle"

    static member inline drawerContent props = Helpers.Elm.props Html.div props "drawer-content"
    static member inline drawerContent (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "drawer-content"
    static member inline drawerContent elm = Helpers.Elm.elm Html.div elm "drawer-content"

    static member inline drawerSide props = Helpers.Elm.props Html.div props "drawer-side"
    static member inline drawerSide (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "drawer-side"
    static member inline drawerSide elm = Helpers.Elm.elm Html.div elm "drawer-side"

    static member inline drawerOverlay props = Helpers.Elm.props Html.label props "drawer-overlay"

    static member inline dropdown props = Helpers.Elm.props Html.div props "dropdown"
    static member inline dropdown (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "dropdown"
    static member inline dropdown elm = Helpers.Elm.elm Html.div elm "dropdown"

    static member inline dropdownContent props = Helpers.Elm.props Html.ul props "dropdown-content"
    static member inline dropdownContent (children: #seq<ReactElement>) = Helpers.Elm.children Html.ul children "dropdown-content"
    static member inline dropdownContent elm = Helpers.Elm.elm Html.ul elm "dropdown-content"

    static member inline footer props = Helpers.Elm.props Html.footer props "footer"
    static member inline footer (children: #seq<ReactElement>) = Helpers.Elm.children Html.footer children "footer"
    static member inline footer elm = Helpers.Elm.elm Html.footer elm "footer"

    static member inline footerTitle props = Helpers.Elm.props Html.span props "footer-title"
    static member inline footerTitle (children: #seq<ReactElement>) = Helpers.Elm.children Html.span children "footer-title"
    static member inline footerTitle elm = Helpers.Elm.elm Html.span elm "footer-title"
    static member inline footerTitle string = Helpers.Elm.string Html.span string "footer-title"
    static member inline footerTitle int = Helpers.Elm.int Html.span int "footer-title"
    static member inline footerTitle float = Helpers.Elm.float Html.span float "footer-title"

    static member inline hero props = Helpers.Elm.props Html.div props "hero"
    static member inline hero (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "hero"
    static member inline hero elm = Helpers.Elm.elm Html.div elm "hero"


    static member inline heroContent props = Helpers.Elm.props Html.div props "hero-content"
    static member inline heroContent (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "hero-content"
    static member inline heroContent elm = Helpers.Elm.elm Html.div elm "hero-content"

    static member inline heroOverlay props = Helpers.Elm.props Html.div props "hero-overlay"
    static member inline heroOverlay (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "hero-overlay"
    static member inline heroOverlay elm = Helpers.Elm.elm Html.div elm "hero-overlay"

    static member inline indicator props = Helpers.Elm.props Html.div props "indicator"
    static member inline indicator (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "indicator"
    static member inline indicator elm = Helpers.Elm.elm Html.div elm "indicator"

    static member inline indicatorItem props = Helpers.Elm.props Html.div props "indicator-item"
    static member inline indicatorItem (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "indicator-item"
    static member inline indicatorItem elm = Helpers.Elm.elm Html.div elm "indicator-item"
    static member inline indicatorItem string = Helpers.Elm.string Html.div string "indicator-item"
    static member inline indicatorItem int = Helpers.Elm.int Html.div int "indicator-item"
    static member inline indicatorItem float = Helpers.Elm.float Html.div float "indicator-item"

    static member inline kbd props = Helpers.Elm.props Html.kbd props "kbd"
    static member inline kbd (children: #seq<ReactElement>) = Helpers.Elm.children Html.kbd children "kbd"
    static member inline kbd elm = Helpers.Elm.elm Html.kbd elm "kbd"
    static member inline kbd string = Helpers.Elm.string Html.kbd string "kbd"
    static member inline kbd int = Helpers.Elm.int Html.kbd int "kbd"
    static member inline kbd float = Helpers.Elm.float Html.kbd float "kbd"

    static member inline link props = Helpers.Elm.props Html.a props "link"
    static member inline link (children: #seq<ReactElement>) = Helpers.Elm.children Html.a children "link"
    static member inline link elm = Helpers.Elm.elm Html.a elm "link"
    static member inline link string = Helpers.Elm.string Html.a string "link"
    static member inline link int = Helpers.Elm.int Html.a int "link"
    static member inline link float = Helpers.Elm.float Html.a float "link"

    static member inline menu props = Helpers.Elm.props Html.ul props "menu"
    static member inline menu (children: #seq<ReactElement>) = Helpers.Elm.children Html.ul children "menu"
    static member inline menu elm = Helpers.Elm.elm Html.ul elm "menu"

    static member inline menuTitle props = Helpers.Elm.props Html.li props "menu-title"
    static member inline menuTitle (children: #seq<ReactElement>) = Helpers.Elm.children Html.li children "menu-title"
    static member inline menuTitle elm = Helpers.Elm.elm Html.li elm "menu-title"
    static member inline menuTitle (title: string) = Helpers.Elm.children Html.li [Html.span title] "menu-title"

    static member inline modal props = Helpers.Elm.props Html.div props "modal"
    static member inline modal (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "modal"
    static member inline modal elm = Helpers.Elm.elm Html.div elm "modal"

    static member inline modalBox props = Helpers.Elm.props Html.div props "modal-box"
    static member inline modalBox (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "modal-box"
    static member inline modalBox elm = Helpers.Elm.elm Html.div elm "modal-box"

    static member inline modalAction props = Helpers.Elm.props Html.div props "modal-action"
    static member inline modalAction (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "modal-action"
    static member inline modalAction elm = Helpers.Elm.elm Html.div elm "modal-action"

    static member inline modalToggle props = Helpers.Elm.props Html.input (prop.type'.checkbox :: props) "modal-toggle"

    static member inline modalButton props = Helpers.Elm.props Html.label props "btn modal-button"
    static member inline modalButton (children: #seq<ReactElement>) = Helpers.Elm.children Html.label children "btn modal-button"
    static member inline modalButton elm = Helpers.Elm.elm Html.label elm "btn modal-button"
    static member inline modalButton string = Helpers.Elm.string Html.label string "btn modal-button"
    static member inline modalButton int = Helpers.Elm.int Html.label int "btn modal-button"
    static member inline modalButton float = Helpers.Elm.float Html.label float "btn modal-button"

    static member inline navbar props = Helpers.Elm.props Html.div props "navbar"
    static member inline navbar (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "navbar"
    static member inline navbar elm = Helpers.Elm.elm Html.div elm "navbar"

    static member inline navbarStart props = Helpers.Elm.props Html.div props "navbar-start"
    static member inline navbarStart (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "navbar-start"
    static member inline navbarStart elm = Helpers.Elm.elm Html.div elm "navbar-start"

    static member inline navbarCenter props = Helpers.Elm.props Html.div props "navbar-center"
    static member inline navbarCenter (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "navbar-center"
    static member inline navbarCenter elm = Helpers.Elm.elm Html.div elm "navbar-center"

    static member inline navbarEnd props = Helpers.Elm.props Html.div props "navbar-end"
    static member inline navbarEnd (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "navbar-end"
    static member inline navbarEnd elm = Helpers.Elm.elm Html.div elm "navbar-end"

    static member inline progress props = Helpers.Elm.props Html.progress props "progress"
    static member inline progress (children: #seq<ReactElement>) = Helpers.Elm.children Html.progress children "progress"
    static member inline progress elm = Helpers.Elm.elm Html.progress elm "progress"

    static member inline stack props = Helpers.Elm.props Html.div props "stack"
    static member inline stack (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "stack"
    static member inline stack elm = Helpers.Elm.elm Html.div elm "stack"

    static member inline stats props = Helpers.Elm.props Html.div props "stats"
    static member inline stats (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "stats"
    static member inline stats elm = Helpers.Elm.elm Html.div elm "stats"
    static member inline stats string = Helpers.Elm.string Html.div string "stats"
    static member inline stats int = Helpers.Elm.int Html.div int "stats"
    static member inline stats float = Helpers.Elm.float Html.div float "stats"

    static member inline stat props = Helpers.Elm.props Html.div props "stat"
    static member inline stat (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "stat"
    static member inline stat elm = Helpers.Elm.elm Html.div elm "stat"
    static member inline stat string = Helpers.Elm.string Html.div string "stat"
    static member inline stat int = Helpers.Elm.int Html.div int "stat"
    static member inline stat float = Helpers.Elm.float Html.div float "stat"

    static member inline statTitle props = Helpers.Elm.props Html.div props "stat-title"
    static member inline statTitle (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "stat-title"
    static member inline statTitle elm = Helpers.Elm.elm Html.div elm "stat-title"
    static member inline statTitle string = Helpers.Elm.string Html.div string "stat-title"
    static member inline statTitle int = Helpers.Elm.int Html.div int "stat-title"
    static member inline statTitle float = Helpers.Elm.float Html.div float "stat-title"

    static member inline statValue props = Helpers.Elm.props Html.div props "stat-value"
    static member inline statValue (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "stat-value"
    static member inline statValue elm = Helpers.Elm.elm Html.div elm "stat-value"
    static member inline statValue string = Helpers.Elm.string Html.div string "stat-value"
    static member inline statValue int = Helpers.Elm.int Html.div int "stat-value"
    static member inline statValue float = Helpers.Elm.float Html.div float "stat-value"

    static member inline statDesc props = Helpers.Elm.props Html.div props "stat-desc"
    static member inline statDesc (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "stat-desc"
    static member inline statDesc elm = Helpers.Elm.elm Html.div elm "stat-desc"
    static member inline statDesc string = Helpers.Elm.string Html.div string "stat-desc"
    static member inline statDesc int = Helpers.Elm.int Html.div int "stat-desc"
    static member inline statDesc float = Helpers.Elm.float Html.div float "stat-desc"

    static member inline statFigure props = Helpers.Elm.props Html.div props "stat-figure"
    static member inline statFigure (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "stat-figure"
    static member inline statFigure elm = Helpers.Elm.elm Html.div elm "stat-figure"
    static member inline statFigure string = Helpers.Elm.string Html.div string "stat-figure"
    static member inline statFigure int = Helpers.Elm.int Html.div int "stat-figure"
    static member inline statFigure float = Helpers.Elm.float Html.div float "stat-figure"

    static member inline steps props = Helpers.Elm.props Html.ul props "steps"
    static member inline steps (children: #seq<ReactElement>) = Helpers.Elm.children Html.ul children "steps"
    static member inline steps elm = Helpers.Elm.elm Html.ul elm "steps"

    static member inline step props = Helpers.Elm.props Html.li props "step"
    static member inline step (children: #seq<ReactElement>) = Helpers.Elm.children Html.li children "step"
    static member inline step elm = Helpers.Elm.elm Html.li elm "step"
    static member inline step string = Helpers.Elm.string Html.li string "step"
    static member inline step int = Helpers.Elm.int Html.li int "step"
    static member inline step float = Helpers.Elm.float Html.li float "step"

    static member inline tabs props = Helpers.Elm.props Html.div props "tabs"
    static member inline tabs (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "tabs"
    static member inline tabs elm = Helpers.Elm.elm Html.div elm "tabs"

    static member inline tab props = Helpers.Elm.props Html.a props "tab"
    static member inline tab (children: #seq<ReactElement>) = Helpers.Elm.children Html.a children "tab"
    static member inline tab elm = Helpers.Elm.elm Html.a elm "tab"
    static member inline tab string = Helpers.Elm.string Html.a string "tab"
    static member inline tab int = Helpers.Elm.int Html.a int "tab"
    static member inline tab float = Helpers.Elm.float Html.a float "tab"

    static member inline table props = Helpers.Elm.props Html.table props "table"
    static member inline table (children: #seq<ReactElement>) = Helpers.Elm.children Html.table children "table"
    static member inline table elm = Helpers.Elm.elm Html.table elm "table"

    static member inline tooltip props = Helpers.Elm.props Html.div props "tooltip"
    static member inline tooltip (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "tooltip"
    static member inline tooltip elm = Helpers.Elm.elm Html.div elm "tooltip"

    static member inline formControl props = Helpers.Elm.props Html.div props "form-control"
    static member inline formControl (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "form-control"
    static member inline formControl elm = Helpers.Elm.elm Html.div elm "form-control"

    static member inline checkbox props = Helpers.Elm.props Html.input (prop.type'.checkbox :: props) "checkbox"

    static member inline label props = Helpers.Elm.props Html.label props "label"
    static member inline label (children: #seq<ReactElement>) = Helpers.Elm.children Html.label children "label"
    static member inline label elm = Helpers.Elm.elm Html.label elm "label"

    static member inline labelText props = Helpers.Elm.props Html.span props "label-text"
    static member inline labelText (children: #seq<ReactElement>) = Helpers.Elm.children Html.span children "label-text"
    static member inline labelText elm = Helpers.Elm.elm Html.span elm "label-text"
    static member inline labelText string = Helpers.Elm.string Html.span string "label-text"
    static member inline labelText int = Helpers.Elm.int Html.span int "label-text"
    static member inline labelText float = Helpers.Elm.float Html.span float "label-text"

    static member inline labelTextAlt props = Helpers.Elm.props Html.span props "label-text-alt"
    static member inline labelTextAlt (children: #seq<ReactElement>) = Helpers.Elm.children Html.span children "label-text-alt"
    static member inline labelTextAlt elm = Helpers.Elm.elm Html.span elm "label-text-alt"
    static member inline labelTextAlt string = Helpers.Elm.string Html.span string "label-text-alt"
    static member inline labelTextAlt int = Helpers.Elm.int Html.span int "label-text-alt"
    static member inline labelTextAlt float = Helpers.Elm.float Html.span float "label-text-alt"

    static member inline input props = Helpers.Elm.props Html.input (prop.type'.text :: props) "input"

    static member inline inputGroup props = Helpers.Elm.props Html.div props "input-group"
    static member inline inputGroup (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "input-group"
    static member inline inputGroup elm = Helpers.Elm.elm Html.div elm "input-group"

    static member inline radio props = Helpers.Elm.props Html.input (prop.type'.radio :: props) "radio"

    static member inline range props = Helpers.Elm.props Html.input (prop.type'.range :: props) "range"

    static member inline select props = Helpers.Elm.props Html.select props "select"
    static member inline select (children: #seq<ReactElement>) = Helpers.Elm.children Html.select children "select"
    static member inline select elm = Helpers.Elm.elm Html.select elm "select"

    static member inline textarea props = Helpers.Elm.props Html.textarea props "textarea"
    static member inline textarea (children: #seq<ReactElement>) = Helpers.Elm.children Html.textarea children "textarea"
    static member inline textarea elm = Helpers.Elm.elm Html.textarea elm "textarea"

    static member inline toggle props = Helpers.Elm.props Html.input (prop.type'.checkbox :: props) "toggle"

    static member inline mockupCode props = Helpers.Elm.props Html.div props "mockup-code"
    static member inline mockupCode (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "mockup-code"
    static member inline mockupCode elm = Helpers.Elm.elm Html.div elm "mockup-code"

    static member inline mockupPhone props = Helpers.Elm.props Html.div props "mockup-phone"
    static member inline mockupPhone (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "mockup-phone"
    static member inline mockupPhone elm = Helpers.Elm.elm Html.div elm "mockup-phone"

    static member inline mockupPhoneCamera props = Helpers.Elm.props Html.div props "camera"
    static member inline mockupPhoneCamera (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "camera"
    static member inline mockupPhoneCamera elm = Helpers.Elm.elm Html.div elm "camera"

    static member inline mockupPhoneDisplay props = Helpers.Elm.props Html.div props "display"
    static member inline mockupPhoneDisplay (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "display"
    static member inline mockupPhoneDisplay elm = Helpers.Elm.elm Html.div elm "display"

    static member inline mockupWindow props = Helpers.Elm.props Html.div props "mockup-window"
    static member inline mockupWindow (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "mockup-window"
    static member inline mockupWindow elm = Helpers.Elm.elm Html.div elm "mockup-window"

    static member inline rating props = Helpers.Elm.props Html.div props "rating"
    static member inline rating (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "rating"
    static member inline rating elm = Helpers.Elm.elm Html.div elm "rating"

    static member inline swap props = Helpers.Elm.props Html.label props "swap"
    static member inline swap (children: #seq<ReactElement>) = Helpers.Elm.children Html.label children "swap"
    static member inline swap elm = Helpers.Elm.elm Html.label elm "swap"

    static member inline swapOn props = Helpers.Elm.props Html.div props "swap-on"
    static member inline swapOn (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "swap-on"
    static member inline swapOn elm = Helpers.Elm.elm Html.div elm "swap-on"
    static member inline swapOn string = Helpers.Elm.string Html.div string "swap-on"
    static member inline swapOn int = Helpers.Elm.int Html.div int "swap-on"
    static member inline swapOn float = Helpers.Elm.float Html.div float "swap-on"

    static member inline swapOff props = Helpers.Elm.props Html.div props "swap-off"
    static member inline swapOff (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "swap-off"
    static member inline swapOff elm = Helpers.Elm.elm Html.div elm "swap-off"
    static member inline swapOff string = Helpers.Elm.string Html.div string "swap-off"
    static member inline swapOff int = Helpers.Elm.int Html.div int "swap-off"
    static member inline swapOff float = Helpers.Elm.float Html.div float "swap-off"

    static member inline swapIndeterminate props = Helpers.Elm.props Html.div props "swap-indeterminate"
    static member inline swapIndeterminate (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "swap-indeterminate"
    static member inline swapIndeterminate elm = Helpers.Elm.elm Html.div elm "swap-indeterminate"
    static member inline swapIndeterminate string = Helpers.Elm.string Html.div string "swap-indeterminate"
    static member inline swapIndeterminate int = Helpers.Elm.int Html.div int "swap-indeterminate"
    static member inline swapIndeterminate float = Helpers.Elm.float Html.div float "swap-indeterminate"

    static member inline radialProgress props = Helpers.Elm.props Html.div props "radial-progress"
    static member inline radialProgress (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "radial-progress"
    static member inline radialProgress elm = Helpers.Elm.elm Html.div elm "radial-progress"
    static member inline radialProgress string = Helpers.Elm.string Html.div string "radial-progress"
    static member inline radialProgress int = Helpers.Elm.int Html.div int "radial-progress"
    static member inline radialProgress float = Helpers.Elm.float Html.div float "radial-progress"

module Daisy =
    [<Erase>]
    type button =
        static member inline div props = Helpers.Elm.props Html.div props "btn"
        static member inline div (children: #seq<ReactElement>) = Helpers.Elm.children Html.div children "btn"
        static member inline div elm = Helpers.Elm.elm Html.div elm "btn"
        static member inline div string = Helpers.Elm.string Html.div string "btn"
        static member inline div int = Helpers.Elm.int Html.div int "btn"
        static member inline div float = Helpers.Elm.float Html.div float "btn"

        static member inline button props = Helpers.Elm.props Html.button props "btn"
        static member inline button (children: #seq<ReactElement>) = Helpers.Elm.children Html.button children "btn"
        static member inline button elm = Helpers.Elm.elm Html.button elm "btn"
        static member inline button string = Helpers.Elm.string Html.button string "btn"
        static member inline button int = Helpers.Elm.int Html.button int "btn"
        static member inline button float = Helpers.Elm.float Html.button float "btn"

        static member inline label props = Helpers.Elm.props Html.label props "btn"
        static member inline label (children: #seq<ReactElement>) = Helpers.Elm.children Html.label children "btn"
        static member inline label elm = Helpers.Elm.elm Html.label elm "btn"
        static member inline label string = Helpers.Elm.string Html.label string "btn"
        static member inline label int = Helpers.Elm.int Html.label int "btn"
        static member inline label float = Helpers.Elm.float Html.label float "btn"

        static member inline a props = Helpers.Elm.props Html.a props "btn"
        static member inline a (children: #seq<ReactElement>) = Helpers.Elm.children Html.a children "btn"
        static member inline a elm = Helpers.Elm.elm Html.a elm "btn"
        static member inline a string = Helpers.Elm.string Html.a string "btn"
        static member inline a int = Helpers.Elm.int Html.a int "btn"
        static member inline a float = Helpers.Elm.float Html.a float "btn"

        static member inline submit props = Helpers.Elm.props Html.input (prop.type'.submit :: props) "btn"
        static member inline reset props = Helpers.Elm.props Html.input (prop.type'.reset :: props) "btn"
        static member inline inputButton props = Helpers.Elm.props Html.input (prop.type'.button :: props) "btn"
