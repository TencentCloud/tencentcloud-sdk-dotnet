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

namespace TencentCloud.Mqtt.V20240516.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAuthorizationPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// 授权策略ID，从 [查询授权策略](https://cloud.tencent.com/document/product/1778/111074) 接口获取
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 腾讯云MQTT实例ID，从 [DescribeInstanceList](https://cloud.tencent.com/document/api/1778/111029)接口或控制台获得。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 策略名称，不能为空，3-64个字符，支持中文、字母、数字、“-”及“_”。
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// 策略版本,默认为1，当前仅支持1
        /// </summary>
        [JsonProperty("PolicyVersion")]
        public long? PolicyVersion{ get; set; }

        /// <summary>
        /// 策略优先级，越小越优先，不能重复
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// 决策：
        /// allow 允许
        /// deny 拒绝
        /// </summary>
        [JsonProperty("Effect")]
        public string Effect{ get; set; }

        /// <summary>
        /// 操作,支持多选，多个操作用英文逗号隔开。可参考 [数据面授权策略说明](https://cloud.tencent.com/document/product/1778/109715)。
        /// connect：连接
        /// pub：发布
        /// sub：订阅
        /// </summary>
        [JsonProperty("Actions")]
        public string Actions{ get; set; }

        /// <summary>
        /// 资源，需要匹配的订阅，支持配置多条匹配规则，多个用英文逗号隔开。可参考 [数据面授权策略说明](https://cloud.tencent.com/document/product/1778/109715)。
        /// </summary>
        [JsonProperty("Resources")]
        public string Resources{ get; set; }

        /// <summary>
        /// 条件-用户名
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// 条件-保留消息
        /// 1,匹配保留消息；
        /// 2,匹配非保留消息，
        /// 3.匹配保留和非保留消息
        /// </summary>
        [JsonProperty("Retain")]
        public long? Retain{ get; set; }

        /// <summary>
        /// 条件：客户端ID，支持正则
        /// </summary>
        [JsonProperty("ClientId")]
        public string ClientId{ get; set; }

        /// <summary>
        /// 条件：客户端IP地址，支持IP或者CIDR
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 条件：服务质量
        /// 0：最多一次
        /// 1：最少一次
        /// 2：精确一次
        /// </summary>
        [JsonProperty("Qos")]
        public string Qos{ get; set; }

        /// <summary>
        /// 备注信息，最长 128 字符
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "PolicyVersion", this.PolicyVersion);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "Effect", this.Effect);
            this.SetParamSimple(map, prefix + "Actions", this.Actions);
            this.SetParamSimple(map, prefix + "Resources", this.Resources);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "Retain", this.Retain);
            this.SetParamSimple(map, prefix + "ClientId", this.ClientId);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Qos", this.Qos);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

