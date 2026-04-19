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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PrometheusInstancesItem : AbstractModel
    {
        
        /// <summary>
        /// <p>实例ID。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>实例名称。</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>实例计费模式。取值范围：</p><ul><li>2：包年包月</li><li>3：按量</li></ul>
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public long? InstanceChargeType{ get; set; }

        /// <summary>
        /// <p>地域 ID</p>
        /// </summary>
        [JsonProperty("RegionId")]
        public long? RegionId{ get; set; }

        /// <summary>
        /// <p>可用区</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>VPC ID</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>子网 ID</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>存储周期</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataRetentionTime")]
        public long? DataRetentionTime{ get; set; }

        /// <summary>
        /// <p>实例业务状态。取值范围：</p><ul><li>1：正在创建</li><li>2：运行中</li><li>3：异常</li><li>4：重建中</li><li>5：销毁中</li><li>6：已停服</li><li>8：欠费停服中</li><li>9：欠费已停服</li></ul>
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public long? InstanceStatus{ get; set; }

        /// <summary>
        /// <p>Grafana 面板 URL</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GrafanaURL")]
        public string GrafanaURL{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// <p>是否开启 Grafana</p><li>0：不开启</li><li>1：开启</li>
        /// </summary>
        [JsonProperty("EnableGrafana")]
        public long? EnableGrafana{ get; set; }

        /// <summary>
        /// <p>实例IPV4地址</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IPv4Address")]
        public string IPv4Address{ get; set; }

        /// <summary>
        /// <p>实例关联的标签列表。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TagSpecification")]
        public PrometheusTag[] TagSpecification{ get; set; }

        /// <summary>
        /// <p>购买的实例过期时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// <p>计费状态</p><ul><li>1：正常</li><li>2：过期</li><li>3：销毁</li><li>4：分配中</li><li>5：分配失败</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChargeStatus")]
        public long? ChargeStatus{ get; set; }

        /// <summary>
        /// <p>规格名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SpecName")]
        public string SpecName{ get; set; }

        /// <summary>
        /// <p>自动续费标记</p><ul><li>0：不自动续费</li><li>1：开启自动续费</li><li>2：禁止自动续费</li><li>-1：无效</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// <p>是否快过期</p><ul><li>0：否</li><li>1：快过期</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsNearExpire")]
        public long? IsNearExpire{ get; set; }

        /// <summary>
        /// <p>数据写入需要的 Token</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthToken")]
        public string AuthToken{ get; set; }

        /// <summary>
        /// <p>Prometheus Remote Write 的地址</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RemoteWrite")]
        public string RemoteWrite{ get; set; }

        /// <summary>
        /// <p>Prometheus HTTP Api 根地址</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiRootPath")]
        public string ApiRootPath{ get; set; }

        /// <summary>
        /// <p>Proxy 的地址</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyAddress")]
        public string ProxyAddress{ get; set; }

        /// <summary>
        /// <p>Grafana 运行状态</p><ul><li>1：正在创建</li><li>2：运行中</li><li>3：异常</li><li>4：重启中</li><li>5：销毁中</li><li>6：已停机</li><li>7：已删除</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GrafanaStatus")]
        public long? GrafanaStatus{ get; set; }

        /// <summary>
        /// <p>Grafana IP 白名单列表，使用英文分号分隔</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GrafanaIpWhiteList")]
        public string GrafanaIpWhiteList{ get; set; }

        /// <summary>
        /// <p>实例的授权信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Grant")]
        public PrometheusInstanceGrantInfo Grant{ get; set; }

        /// <summary>
        /// <p>绑定的 Grafana 实例 ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GrafanaInstanceId")]
        public string GrafanaInstanceId{ get; set; }

        /// <summary>
        /// <p>告警规则限制</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlertRuleLimit")]
        public long? AlertRuleLimit{ get; set; }

        /// <summary>
        /// <p>预聚合规则限制</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecordingRuleLimit")]
        public long? RecordingRuleLimit{ get; set; }

        /// <summary>
        /// <p>迁移状态，0-不在迁移中，1-迁移中、原实例，2-迁移中、目标实例</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MigrationType")]
        public long? MigrationType{ get; set; }

        /// <summary>
        /// <p>标识prom实例特殊属性</p><p>归档存储时长(天):<br>key: LongTermStorageRetentionTime<br>value: 60-730</p><p>实例创建方式：<br>key: CreatedFrom<br>value: 0 - 来自prom控制台<br>1 - 来自tke集群详情页<br>2 - 来自新建集群页</p><p>免费试用到期时间:<br>key: FreeTrialExpireAt<br>value: RFC3339 格式时间字符串</p><p>关联的资源包ID:<br>key: ResourcePackageID<br>value: prompkg-xxxxx</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceAttributes")]
        public PrometheusRuleKV[] InstanceAttributes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "DataRetentionTime", this.DataRetentionTime);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "GrafanaURL", this.GrafanaURL);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "EnableGrafana", this.EnableGrafana);
            this.SetParamSimple(map, prefix + "IPv4Address", this.IPv4Address);
            this.SetParamArrayObj(map, prefix + "TagSpecification.", this.TagSpecification);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "ChargeStatus", this.ChargeStatus);
            this.SetParamSimple(map, prefix + "SpecName", this.SpecName);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "IsNearExpire", this.IsNearExpire);
            this.SetParamSimple(map, prefix + "AuthToken", this.AuthToken);
            this.SetParamSimple(map, prefix + "RemoteWrite", this.RemoteWrite);
            this.SetParamSimple(map, prefix + "ApiRootPath", this.ApiRootPath);
            this.SetParamSimple(map, prefix + "ProxyAddress", this.ProxyAddress);
            this.SetParamSimple(map, prefix + "GrafanaStatus", this.GrafanaStatus);
            this.SetParamSimple(map, prefix + "GrafanaIpWhiteList", this.GrafanaIpWhiteList);
            this.SetParamObj(map, prefix + "Grant.", this.Grant);
            this.SetParamSimple(map, prefix + "GrafanaInstanceId", this.GrafanaInstanceId);
            this.SetParamSimple(map, prefix + "AlertRuleLimit", this.AlertRuleLimit);
            this.SetParamSimple(map, prefix + "RecordingRuleLimit", this.RecordingRuleLimit);
            this.SetParamSimple(map, prefix + "MigrationType", this.MigrationType);
            this.SetParamArrayObj(map, prefix + "InstanceAttributes.", this.InstanceAttributes);
        }
    }
}

