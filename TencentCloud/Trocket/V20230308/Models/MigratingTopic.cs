/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class MigratingTopic : AbstractModel
    {
        
        /// <summary>
        /// 主题名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// 迁移状态 S_RW_D_NA 源集群读写 S_RW_D_R 源集群读写目标集群读 S_RW_D_RW 源集群读写目标集群读写 S_R_D_RW 源集群读目标集群读写 S_NA_D_RW 目标集群读写
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MigrationStatus")]
        public string MigrationStatus{ get; set; }

        /// <summary>
        /// 是否完成健康检查	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HealthCheckPassed")]
        public bool? HealthCheckPassed{ get; set; }

        /// <summary>
        /// 上次健康检查返回的错误信息，仅在HealthCheckPassed为false时有效。 NotChecked 未执行检查， Unknown 未知错误, TopicNotImported 主题未导入, TopicNotExistsInSourceCluster 主题在源集群中不存在, TopicNotExistsInTargetCluster 主题在目标集群中不存在, ConsumerConnectedOnTarget 目标集群上存在消费者连接, SourceTopicHasNewMessagesIn5Minutes 源集群主题前5分钟内有新消息写入, TargetTopicHasNewMessagesIn5Minutes 目标集群主题前5分钟内有新消息写入, SourceTopicHasNoMessagesIn5Minutes 源集群前5分钟内没有新消息写入, TargetTopicHasNoMessagesIn5Minutes 源集群前5分钟内没有新消息写入, ConsumerGroupCountNotMatch 订阅组数量不一致, SourceTopicHasUnconsumedMessages 源集群主题存在未消费消息,
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HealthCheckError")]
        public string HealthCheckError{ get; set; }

        /// <summary>
        /// 命名空间，仅4.x集群有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "MigrationStatus", this.MigrationStatus);
            this.SetParamSimple(map, prefix + "HealthCheckPassed", this.HealthCheckPassed);
            this.SetParamSimple(map, prefix + "HealthCheckError", this.HealthCheckError);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
        }
    }
}

