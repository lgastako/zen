(ns zen.core-test
  (:require [clojure.test :refer :all]
            [zen.core :as zen]))

(deftest parse-test
  (testing "integers"
    (is (= '([:integer "1"])
           (zen/parse "1"))))

  (testing "booleans"
    (is (= '([:boolean "true"])
           (zen/parse "true")))))

(deftest eval-test
  (testing "integers"
    (is (= '(1)
           (zen/eval "1"))))

  (testing "decimals"
    (is (= '(3.14159)
           (zen/eval "3.14159"))))

  (testing "booleans"
    (is (= '(true)
           (zen/eval "true")))
    (is (= '(false)
           (zen/eval "false"))))

  (testing "lambdas"
    (is (= '([:lambda "x" 1])
           (zen/eval "λ x . 1"))))

  ;; (testing "application"
  ;;   (is (= '([:lambda "x" [:body "x"]]
  ;;            [:lambda "x" [:body "x"]])
  ;;          (zen/eval "(λ x . x) (λ x . x)")))

  ;;   (is (= "f 5"
  ;;          (zen/eval "f 5"))))
  )

(run-tests)
