(ns zen.core
  (:require [clojure.java.io :as io]
            [instaparse.core :as insta]))

(def parse
  (insta/parser (io/resource "zen.bnf")))

(defn eval [s]
  (->> (parse s)
       (insta/transform {:integer clojure.edn/read-string
                         :name str})))

;; lambda = λ name . expr
;; let = <'let'> (indented-arg-list | unindented-arg-list) <'in'> expr
;; alphanum = letter | digit
;; name = letter alphanum*
;; lambda = λ name . expr
;; expr = name | value
