(ns zen.core
  (:require [instaparse.core :as insta]))

(def parse
  (insta/parser
   "NAME = ...
    EXPR = FUNC | NAME | APPL
    FUNC = λ NAME . EXPR"))

;; (def as-and-bs
;;   (insta/parser
;;    "S = AB*
;;     AB = A B
;;     A = 'a'+
;;     B = 'b'+"))

;; ;; => (as-and-bs "aaaaabbbaaaabb")
;; ;; [:S
;; ;;  [:AB [:A "a" "a" "a" "a" "a"] [:B "b" "b" "b"]]
;; ;;  [:AB [:A "a" "a" "a" "a"] [:B "b" "b"]]]

;; [:S
;;  [:AB [:A "a" "a" "a" "a" "a"] [:B "b" "b" "b"]]
;;   [:AB [:A "a" "a" "a" "a"] [:B "b" "b"]]
