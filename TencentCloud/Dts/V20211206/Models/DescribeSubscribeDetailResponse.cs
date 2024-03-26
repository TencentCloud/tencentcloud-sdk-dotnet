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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSubscribeDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 数据订阅的ID，形如subs-b6x64o31tm
        /// </summary>
        [JsonProperty("SubscribeId")]
        public string SubscribeId{ get; set; }

        /// <summary>
        /// 数据订阅实例的名称
        /// </summary>
        [JsonProperty("SubscribeName")]
        public string SubscribeName{ get; set; }

        /// <summary>
        /// 订阅的数据库类型，目前支持 cynosdbmysql(tdsql-c mysql版),mariadb,mongodb,mysql,percona,tdpg(tdsql postgresql版),tdsqlpercona(tdsql mysql版)
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// 订阅的云数据库实例ID，只有订阅云数据库该值才有意义
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 订阅的云数据库实例状态，只有订阅云数据库该值才有意义。可能值为：running, isolated, offline
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// 订阅任务计费状态，可能值为：正常normal, 隔离中isolating, 已隔离isolated, 下线中offlining, 按量转包年包月中 post2PrePayIng
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 订阅任务状态，可能值为：未启动notStarted, 校验中checking, 校验不通过checkNotPass, 校验通过checkPass, 启动中starting, 运行中running, 异常出错error
        /// </summary>
        [JsonProperty("SubsStatus")]
        public string SubsStatus{ get; set; }

        /// <summary>
        /// 修改时间，时间格式如：Y-m-d h:m:s
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 创建时间，时间格式如：Y-m-d h:m:s
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 隔离时间，时间格式如：Y-m-d h:m:s。默认：0000-00-00 00:00:00
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsolateTime")]
        public string IsolateTime{ get; set; }

        /// <summary>
        /// 包年包月任务的到期时间，时间格式如：Y-m-d h:m:s。默认：0000-00-00 00:00:00
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 下线时间，时间格式如：Y-m-d h:m:s。默认：0000-00-00 00:00:00
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OfflineTime")]
        public string OfflineTime{ get; set; }

        /// <summary>
        /// 付费方式，可能值为：0-包年包月，1-按量计费
        /// </summary>
        [JsonProperty("PayType")]
        public long? PayType{ get; set; }

        /// <summary>
        /// 自动续费标识。只有当 PayType=0，该值才有意义。枚举值：0-不自动续费，1-自动续费
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 任务所在地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Kafka topic
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Topic")]
        public string Topic{ get; set; }

        /// <summary>
        /// Kafka服务Broker地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Broker")]
        public string Broker{ get; set; }

        /// <summary>
        /// 数据订阅的类型，当 Product 不为 mongodb 时，可能值为：all-全实例更新；dml-数据更新；ddl-结构更新；dmlAndDdl-数据更新+结构更新。当 Product 为 mongodb 时，可能值为 all-全实例更新；database-订阅单库；collection-订阅单集合
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubscribeMode")]
        public string SubscribeMode{ get; set; }

        /// <summary>
        /// 订阅数据格式。如果为空则用的默认格式: mysql\cynosdbmysql\mariadb\percona\tdsqlpercona\tdpg是protobuf，mongo是json。当 DatabaseType 为 mysql和cynosdbmysql 时有三种可选协议：protobuf\avro\json。数据格式详情参考官网的消费demo文档
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 订阅的数据库表信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubscribeObjects")]
        public SubscribeObject[] SubscribeObjects{ get; set; }

        /// <summary>
        /// kafka配置信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KafkaConfig")]
        public SubscribeKafkaConfig KafkaConfig{ get; set; }

        /// <summary>
        /// 订阅内置kafka的版本信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KafkaVersion")]
        public string KafkaVersion{ get; set; }

        /// <summary>
        /// 源数据库接入类型，如：extranet(公网)、vpncloud(vpn接入)、dcg(专线接入)、ccn(云联网)、cdb(云数据库)、cvm(云服务器自建)、intranet(自研上云)、vpc(私有网络vpc)。注意具体可选值依赖当前链路支持能力
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccessType")]
        public string AccessType{ get; set; }

        /// <summary>
        /// 接入类型信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Endpoints")]
        public EndpointItem[] Endpoints{ get; set; }

        /// <summary>
        /// mongo输出聚合设置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PipelineInfo")]
        public PipelineInfo[] PipelineInfo{ get; set; }

        /// <summary>
        /// 标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public TagItem[] Tags{ get; set; }

        /// <summary>
        /// 订阅任务报错信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Errors")]
        public SubsErr[] Errors{ get; set; }

        /// <summary>
        /// 为业务添加的额外信息。参数名作key，参数值作value。
        /// mysql选填参数：ProcessXA-是否处理XA事务，为true处理，其他不处理。
        /// mongo选填参数：SubscribeType-订阅类型，目前只支持changeStream。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtraAttr")]
        public KeyValuePairOption[] ExtraAttr{ get; set; }

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
            this.SetParamSimple(map, prefix + "SubscribeId", this.SubscribeId);
            this.SetParamSimple(map, prefix + "SubscribeName", this.SubscribeName);
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SubsStatus", this.SubsStatus);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "IsolateTime", this.IsolateTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "OfflineTime", this.OfflineTime);
            this.SetParamSimple(map, prefix + "PayType", this.PayType);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamSimple(map, prefix + "Broker", this.Broker);
            this.SetParamSimple(map, prefix + "SubscribeMode", this.SubscribeMode);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamArrayObj(map, prefix + "SubscribeObjects.", this.SubscribeObjects);
            this.SetParamObj(map, prefix + "KafkaConfig.", this.KafkaConfig);
            this.SetParamSimple(map, prefix + "KafkaVersion", this.KafkaVersion);
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamArrayObj(map, prefix + "Endpoints.", this.Endpoints);
            this.SetParamArrayObj(map, prefix + "PipelineInfo.", this.PipelineInfo);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArrayObj(map, prefix + "Errors.", this.Errors);
            this.SetParamArrayObj(map, prefix + "ExtraAttr.", this.ExtraAttr);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

