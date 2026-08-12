/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RegisterEvent : AbstractModel
    {
        
        /// <summary>
        /// <p>注册结果</p>
        /// </summary>
        [JsonProperty("RegisterResult")]
        public Result RegisterResult{ get; set; }

        /// <summary>
        /// <p>用户基础信息</p>
        /// </summary>
        [JsonProperty("UserInfo")]
        public User UserInfo{ get; set; }

        /// <summary>
        /// <p>用户注册时填写的个人信息</p>
        /// </summary>
        [JsonProperty("Person")]
        public Person Person{ get; set; }

        /// <summary>
        /// <p>用户注册时填写的账单地址</p>
        /// </summary>
        [JsonProperty("BillingAddress")]
        public Address BillingAddress{ get; set; }

        /// <summary>
        /// <p>用户注册时填写的收货地址</p>
        /// </summary>
        [JsonProperty("DeliveryAddress")]
        public Address DeliveryAddress{ get; set; }

        /// <summary>
        /// <p>邀请人信息</p>
        /// </summary>
        [JsonProperty("Inviter")]
        public Inviter Inviter{ get; set; }

        /// <summary>
        /// <p>与RCE约定的定制化信息，为K:V 格式的对象数组，示例：[{&quot;Key&quot;: &quot;ApproverName&quot;, &quot;Value&quot;: &quot;bob&quot;},{&quot;Key&quot;:&quot;ApproverPhone&quot;,&quot;Value&quot;: &quot;+86131****5678&quot;}]</p>
        /// </summary>
        [JsonProperty("Cust")]
        public Cust[] Cust{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "RegisterResult.", this.RegisterResult);
            this.SetParamObj(map, prefix + "UserInfo.", this.UserInfo);
            this.SetParamObj(map, prefix + "Person.", this.Person);
            this.SetParamObj(map, prefix + "BillingAddress.", this.BillingAddress);
            this.SetParamObj(map, prefix + "DeliveryAddress.", this.DeliveryAddress);
            this.SetParamObj(map, prefix + "Inviter.", this.Inviter);
            this.SetParamArrayObj(map, prefix + "Cust.", this.Cust);
        }
    }
}

