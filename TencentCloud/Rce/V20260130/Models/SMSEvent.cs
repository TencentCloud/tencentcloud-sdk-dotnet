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

    public class SMSEvent : AbstractModel
    {
        
        /// <summary>
        /// <p>用户基础信息</p>
        /// </summary>
        [JsonProperty("UserInfo")]
        public User UserInfo{ get; set; }

        /// <summary>
        /// <p>本次短信发送标识 ID</p>
        /// </summary>
        [JsonProperty("SMSId")]
        public string SMSId{ get; set; }

        /// <summary>
        /// <p>用户实际完成验证码时间</p><p>参数格式：符合ISO 8601标准的带UTC时区的毫秒级时间</p>
        /// </summary>
        [JsonProperty("ReceivedTime")]
        public string ReceivedTime{ get; set; }

        /// <summary>
        /// <p>记录用户收到短信的动作</p><ul><li>no_action：用户无动作</li><li>safe：用户确认本人操作</li><li>compromised：用户反馈为第三方操作</li></ul>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// <p>短信回执结果</p>
        /// </summary>
        [JsonProperty("SMSResult")]
        public Result SMSResult{ get; set; }

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
            this.SetParamObj(map, prefix + "UserInfo.", this.UserInfo);
            this.SetParamSimple(map, prefix + "SMSId", this.SMSId);
            this.SetParamSimple(map, prefix + "ReceivedTime", this.ReceivedTime);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamObj(map, prefix + "SMSResult.", this.SMSResult);
            this.SetParamArrayObj(map, prefix + "Cust.", this.Cust);
        }
    }
}

