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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeliveryConfigBindGroup : AbstractModel
    {
        
        /// <summary>
        /// 配置id
        /// </summary>
        [JsonProperty("ConfigId")]
        public string ConfigId{ get; set; }

        /// <summary>
        /// 配置名
        /// </summary>
        [JsonProperty("ConfigName")]
        public string ConfigName{ get; set; }

        /// <summary>
        /// 采集路径
        /// </summary>
        [JsonProperty("CollectPath")]
        public string[] CollectPath{ get; set; }

        /// <summary>
        /// 关联部署组信息
        /// </summary>
        [JsonProperty("Groups")]
        public GroupInfo[] Groups{ get; set; }

        /// <summary>
        /// 创建时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Kafka的vip
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KafkaVIp")]
        public string KafkaVIp{ get; set; }

        /// <summary>
        /// Kafka地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KafkaAddress")]
        public string KafkaAddress{ get; set; }

        /// <summary>
        /// Kafka端口
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KafkaVPort")]
        public string KafkaVPort{ get; set; }

        /// <summary>
        /// Topic
        /// </summary>
        [JsonProperty("Topic")]
        public string Topic{ get; set; }

        /// <summary>
        /// LineRule
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LineRule")]
        public string LineRule{ get; set; }

        /// <summary>
        /// 自定义规则
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomRule")]
        public string CustomRule{ get; set; }

        /// <summary>
        /// EnableGlobalLineRule
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableGlobalLineRule")]
        public bool? EnableGlobalLineRule{ get; set; }

        /// <summary>
        /// 是否开启认证
        /// </summary>
        [JsonProperty("EnableAuth")]
        public bool? EnableAuth{ get; set; }

        /// <summary>
        /// 用户名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// 密码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// KafkaInfos
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KafkaInfos")]
        public DeliveryKafkaInfo[] KafkaInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigId", this.ConfigId);
            this.SetParamSimple(map, prefix + "ConfigName", this.ConfigName);
            this.SetParamArraySimple(map, prefix + "CollectPath.", this.CollectPath);
            this.SetParamArrayObj(map, prefix + "Groups.", this.Groups);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "KafkaVIp", this.KafkaVIp);
            this.SetParamSimple(map, prefix + "KafkaAddress", this.KafkaAddress);
            this.SetParamSimple(map, prefix + "KafkaVPort", this.KafkaVPort);
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamSimple(map, prefix + "LineRule", this.LineRule);
            this.SetParamSimple(map, prefix + "CustomRule", this.CustomRule);
            this.SetParamSimple(map, prefix + "EnableGlobalLineRule", this.EnableGlobalLineRule);
            this.SetParamSimple(map, prefix + "EnableAuth", this.EnableAuth);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamArrayObj(map, prefix + "KafkaInfos.", this.KafkaInfos);
        }
    }
}

