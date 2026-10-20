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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeliverServerItem : AbstractModel
    {
        
        /// <summary>
        /// <p>服务器id  (创建时忽略)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ID")]
        public ulong? ID{ get; set; }

        /// <summary>
        /// <p>服务器名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>转发服务器地址类型 4:syslog, 2:kafka, 3:http(只支持32位)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// <p>服务器描述</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>syslog服务器地址</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetSyslogAddress")]
        public string TargetSyslogAddress{ get; set; }

        /// <summary>
        /// <p>syslog协议类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetSyslogProtocol")]
        public string TargetSyslogProtocol{ get; set; }

        /// <summary>
        /// <p>syslog协议端口(只支持32位)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetSyslogPort")]
        public ulong? TargetSyslogPort{ get; set; }

        /// <summary>
        /// <p>syslog设备/Facility</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SyslogFacility")]
        public string SyslogFacility{ get; set; }

        /// <summary>
        /// <p>Kafka服务器地址</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetKafkaAddress")]
        public string TargetKafkaAddress{ get; set; }

        /// <summary>
        /// <p>Kafka主题</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetKafkaTopic")]
        public string TargetKafkaTopic{ get; set; }

        /// <summary>
        /// <p>Kafka版本</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KafkaVersion")]
        public string KafkaVersion{ get; set; }

        /// <summary>
        /// <p>Kafka sasl用户名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KafkaSaslUserName")]
        public string KafkaSaslUserName{ get; set; }

        /// <summary>
        /// <p>Kafka sasl密码</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KafkaSaslPassword")]
        public string KafkaSaslPassword{ get; set; }

        /// <summary>
        /// <p>http服务器地址</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetHttpUrl")]
        public string TargetHttpUrl{ get; set; }

        /// <summary>
        /// <p>http服务超时时间(只支持32位)</p><p>单位：毫秒</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetHttpTimeout")]
        public ulong? TargetHttpTimeout{ get; set; }

        /// <summary>
        /// <p>连接器分组ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConnectorGroupId")]
        public string ConnectorGroupId{ get; set; }

        /// <summary>
        /// <p>连接器分组名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConnectorGroupName")]
        public string ConnectorGroupName{ get; set; }

        /// <summary>
        /// <p>KAFKA是否启用SSL</p>
        /// </summary>
        [JsonProperty("KafkaSSLEnable")]
        public bool? KafkaSSLEnable{ get; set; }

        /// <summary>
        /// <p>跳过证书检查</p>
        /// </summary>
        [JsonProperty("SSLSkipVerify")]
        public bool? SSLSkipVerify{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "TargetSyslogAddress", this.TargetSyslogAddress);
            this.SetParamSimple(map, prefix + "TargetSyslogProtocol", this.TargetSyslogProtocol);
            this.SetParamSimple(map, prefix + "TargetSyslogPort", this.TargetSyslogPort);
            this.SetParamSimple(map, prefix + "SyslogFacility", this.SyslogFacility);
            this.SetParamSimple(map, prefix + "TargetKafkaAddress", this.TargetKafkaAddress);
            this.SetParamSimple(map, prefix + "TargetKafkaTopic", this.TargetKafkaTopic);
            this.SetParamSimple(map, prefix + "KafkaVersion", this.KafkaVersion);
            this.SetParamSimple(map, prefix + "KafkaSaslUserName", this.KafkaSaslUserName);
            this.SetParamSimple(map, prefix + "KafkaSaslPassword", this.KafkaSaslPassword);
            this.SetParamSimple(map, prefix + "TargetHttpUrl", this.TargetHttpUrl);
            this.SetParamSimple(map, prefix + "TargetHttpTimeout", this.TargetHttpTimeout);
            this.SetParamSimple(map, prefix + "ConnectorGroupId", this.ConnectorGroupId);
            this.SetParamSimple(map, prefix + "ConnectorGroupName", this.ConnectorGroupName);
            this.SetParamSimple(map, prefix + "KafkaSSLEnable", this.KafkaSSLEnable);
            this.SetParamSimple(map, prefix + "SSLSkipVerify", this.SSLSkipVerify);
        }
    }
}

