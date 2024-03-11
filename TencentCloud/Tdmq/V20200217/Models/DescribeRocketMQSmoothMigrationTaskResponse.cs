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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRocketMQSmoothMigrationTaskResponse : AbstractModel
    {
        
        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 目标集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 源集群名称
        /// </summary>
        [JsonProperty("SourceClusterName")]
        public string SourceClusterName{ get; set; }

        /// <summary>
        /// 网络连接类型，
        /// PUBLIC 公网
        /// VPC 私有网络
        /// OTHER 其它
        /// </summary>
        [JsonProperty("ConnectionType")]
        public string ConnectionType{ get; set; }

        /// <summary>
        /// 源集群NameServer地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceClusterNameServer")]
        public string SourceClusterNameServer{ get; set; }

        /// <summary>
        /// 源集群所在私有网络ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 源集群所在子网ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 是否开启ACL
        /// </summary>
        [JsonProperty("EnableACL")]
        public bool? EnableACL{ get; set; }

        /// <summary>
        /// 源集群AccessKey
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccessKey")]
        public string AccessKey{ get; set; }

        /// <summary>
        /// 元集群SecretKey
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecretKey")]
        public string SecretKey{ get; set; }

        /// <summary>
        /// 配置源集群时发生的错误
        /// TIMEOUT 连接超时，
        /// SERVER_ERROR 服务错误，
        /// INTERNAL_ERROR 内部错误，
        /// CONNECT_NAMESERVER_ERROR 连接nameserver错误
        /// CONNECT_BROKER_ERROR 连接broker错误
        /// ACL_WRONG ACL信息不正确
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskError")]
        public string TaskError{ get; set; }

        /// <summary>
        /// 任务状态
        /// Configuration 迁移配置
        /// SourceConnecting 连接源集群中
        /// SourceConnectionFailure 连接源集群失败
        /// MetaDataImport 元数据导入
        /// EndpointSetup 切换接入点
        /// ServiceMigration 切流中
        /// Completed 已完成
        /// Cancelled 已取消
        /// </summary>
        [JsonProperty("TaskStatus")]
        public string TaskStatus{ get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 主题类型分布情况
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TopicTypeDistribution")]
        public RocketMQTopicDistribution[] TopicTypeDistribution{ get; set; }

        /// <summary>
        /// 主题迁移进度分布情况
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TopicStageDistribution")]
        public RocketMQMigrationTopicDistribution[] TopicStageDistribution{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "SourceClusterName", this.SourceClusterName);
            this.SetParamSimple(map, prefix + "ConnectionType", this.ConnectionType);
            this.SetParamSimple(map, prefix + "SourceClusterNameServer", this.SourceClusterNameServer);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "EnableACL", this.EnableACL);
            this.SetParamSimple(map, prefix + "AccessKey", this.AccessKey);
            this.SetParamSimple(map, prefix + "SecretKey", this.SecretKey);
            this.SetParamSimple(map, prefix + "TaskError", this.TaskError);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamArrayObj(map, prefix + "TopicTypeDistribution.", this.TopicTypeDistribution);
            this.SetParamArrayObj(map, prefix + "TopicStageDistribution.", this.TopicStageDistribution);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

