(ns zen.core
  (:require [clojure.java.io :as io]
            [instaparse.core :as insta]))

(def parse
  (insta/parser (io/resource "zen.bnf")))

(defn eval [s]
  (->> (parse s)
       (insta/transform {:integer clojure.edn/read-string
                         :decimal clojure.edn/read-string
                         :boolean clojure.edn/read-string
                         :name str})))

;; let = <'let'> (indented-arg-list | unindented-arg-list) <'in'> expr
;; application = f expr
;; f           = name | lambda
;; lambda      = <'λ'> <whitespace> expr <whitespace> <'.'> <whitespace> body
;; name        = letter alphanum*
;; body        = value | name
