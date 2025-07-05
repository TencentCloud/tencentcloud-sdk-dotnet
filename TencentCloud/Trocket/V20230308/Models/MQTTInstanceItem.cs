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

namespace TencentCloud.Trocket.V20230308.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MQTTInstanceItem : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 实例版本
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// 实例类型，
        /// BASIC，基础版
        /// PRO，专业版
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 实例状态，
        /// RUNNING, 运行中
        /// MAINTAINING，维护中
        /// ABNORMAL，异常
        /// OVERDUE，欠费
        /// DESTROYED，已删除
        /// CREATING，创建中
        /// MODIFYING，变配中
        /// CREATE_FAILURE，创建失败
        /// MODIFY_FAILURE，变配失败
        /// DELETING，删除中
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// 实例主题数上限
        /// </summary>
        [JsonProperty("TopicNumLimit")]
        public long? TopicNumLimit{ get; set; }

        /// <summary>
        /// 备注信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 主题数量
        /// </summary>
        [JsonProperty("TopicNum")]
        public long? TopicNum{ get; set; }

        /// <summary>
        /// 商品规格
        /// </summary>
        [JsonProperty("SkuCode")]
        public string SkuCode{ get; set; }

        /// <summary>
        /// 弹性TPS限流值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TpsLimit")]
        public long? TpsLimit{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// 订阅关系上限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubscriptionNumLimit")]
        public long? SubscriptionNumLimit{ get; set; }

        /// <summary>
        /// 客户端连接数上线
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClientNumLimit")]
        public long? ClientNumLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "TopicNumLimit", this.TopicNumLimit);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "TopicNum", this.TopicNum);
            this.SetParamSimple(map, prefix + "SkuCode", this.SkuCode);
            this.SetParamSimple(map, prefix + "TpsLimit", this.TpsLimit);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "SubscriptionNumLimit", this.SubscriptionNumLimit);
            this.SetParamSimple(map, prefix + "ClientNumLimit", this.ClientNumLimit);
        }
    }
}

