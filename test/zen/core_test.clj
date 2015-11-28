(ns zen.core-test
  (:require [clojure.test :refer :all]
            [zen.core :as zen]))

(deftest parse-test
  (is (= '([:integer "1"])
         (zen/parse "1"))))

(deftest parse-eval
  (is (= '(1)
         (zen/eval "1"))))

(run-tests)
