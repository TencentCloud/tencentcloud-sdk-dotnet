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

namespace TencentCloud.Vdb.V20230616.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 私有网络 ID。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 私有网络 VPC 的子网 ID。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 指定实例计费方式。
        /// - 0：按量付费。
        /// - 1：包年包月。
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// 设置实例名称。仅支持长度不超过 60 的中文/英文/数字/-/_。
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 安全组 ID。
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// 若计费方式为包年包月，指定包年包月续费的时长。
        /// - 单位：月。
        /// - 取值范围：1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 24, 36。默认为1。
        /// </summary>
        [JsonProperty("PayPeriod")]
        public long? PayPeriod{ get; set; }

        /// <summary>
        /// 若为包年包月计费，需指定是否开启自动续费。
        /// - 0：不开启自动续费。
        /// - 1：开启自动续费。
        /// </summary>
        [JsonProperty("AutoRenew")]
        public long? AutoRenew{ get; set; }

        /// <summary>
        /// 实例额外参数，通过json提交。
        /// </summary>
        [JsonProperty("Params")]
        public string Params{ get; set; }

        /// <summary>
        /// 以数组形式列出标签信息。
        /// </summary>
        [JsonProperty("ResourceTags")]
        public Tag[] ResourceTags{ get; set; }

        /// <summary>
        /// 指定实例所属项目 ID。
        /// </summary>
        [JsonProperty("Project")]
        [System.Obsolete]
        public string Project{ get; set; }

        /// <summary>
        /// 产品版本，0-标准版，1-容量增强版
        /// </summary>
        [JsonProperty("ProductType")]
        public long? ProductType{ get; set; }

        /// <summary>
        /// 实例类型。
        /// - base：免费测试版。
        /// - single：单机版。
        /// - cluster：高可用版。
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 实例类型为高可用版，需指定可用区选项。
        /// - two：两可用区。
        /// - three：三可用区。
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// 购买实例数量。
        /// </summary>
        [JsonProperty("GoodsNum")]
        public long? GoodsNum{ get; set; }

        /// <summary>
        /// 网络类型。
        /// VPC或TCS
        /// </summary>
        [JsonProperty("NetworkType")]
        [System.Obsolete]
        public string NetworkType{ get; set; }

        /// <summary>
        /// 实例所应用的参数模板 ID。
        /// </summary>
        [JsonProperty("TemplateId")]
        [System.Obsolete]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 组件具体设置列表。
        /// </summary>
        [JsonProperty("Components")]
        [System.Obsolete]
        public CreateInstancesComponent[] Components{ get; set; }

        /// <summary>
        /// 实例类型为高可用版，通过该参数指定主可用区。
        /// </summary>
        [JsonProperty("Zone")]
        [System.Obsolete]
        public string Zone{ get; set; }

        /// <summary>
        /// 实例类型为高可用版，通过该参数指定备可用区。
        /// </summary>
        [JsonProperty("SlaveZones")]
        [System.Obsolete]
        public string[] SlaveZones{ get; set; }

        /// <summary>
        /// 是否长期有效
        /// </summary>
        [JsonProperty("IsNoExpired")]
        [System.Obsolete]
        public bool? IsNoExpired{ get; set; }

        /// <summary>
        /// 引擎名称，业务自定义。
        /// </summary>
        [JsonProperty("EngineName")]
        [System.Obsolete]
        public string EngineName{ get; set; }

        /// <summary>
        /// 引擎版本，业务自定义。
        /// </summary>
        [JsonProperty("EngineVersion")]
        [System.Obsolete]
        public string EngineVersion{ get; set; }

        /// <summary>
        /// 实例描述。
        /// </summary>
        [JsonProperty("Brief")]
        [System.Obsolete]
        public string Brief{ get; set; }

        /// <summary>
        /// 负责人信息。
        /// </summary>
        [JsonProperty("Chief")]
        [System.Obsolete]
        public string Chief{ get; set; }

        /// <summary>
        /// DBA人员信息
        /// </summary>
        [JsonProperty("DBA")]
        [System.Obsolete]
        public string DBA{ get; set; }

        /// <summary>
        /// 指定实例的节点类型。具体信息，请参见[选择节点类型](https://cloud.tencent.com/document/product/1709/113399)。
        /// - compute：计费型。
        /// - normal：标准型。
        /// - store：存储型。
        /// </summary>
        [JsonProperty("NodeType")]
        [System.Obsolete]
        public string NodeType{ get; set; }

        /// <summary>
        /// 指定实例所需的 CPU 核数。实例类型不同，支持的 CPU 核数存在差异。
        /// - 计算型： 1、2、4、8、16、24、32。
        /// - 标准型： 1、2、4、8、12、16。
        /// - 存储型： 1、2、4、6、8。
        /// </summary>
        [JsonProperty("Cpu")]
        public ulong? Cpu{ get; set; }

        /// <summary>
        /// 指定实例所需的内存大小。单位：GB。选择具体规格，请参见[配置规格（选型）](https://cloud.tencent.com/document/product/1709/113399)。
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// 指定实例所需的磁盘大小，单位：GB。选择具体规格，请参见[配置规格（选型）](https://cloud.tencent.com/document/product/1709/113399)。
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// 指定实例所需配置的节点数量。选择方法，请参见[配置规格（选型）](https://cloud.tencent.com/document/product/1709/113399)。
        /// </summary>
        [JsonProperty("WorkerNodeNum")]
        public ulong? WorkerNodeNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamSimple(map, prefix + "PayPeriod", this.PayPeriod);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
            this.SetParamSimple(map, prefix + "Params", this.Params);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "Project", this.Project);
            this.SetParamSimple(map, prefix + "ProductType", this.ProductType);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamArrayObj(map, prefix + "Components.", this.Components);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamArraySimple(map, prefix + "SlaveZones.", this.SlaveZones);
            this.SetParamSimple(map, prefix + "IsNoExpired", this.IsNoExpired);
            this.SetParamSimple(map, prefix + "EngineName", this.EngineName);
            this.SetParamSimple(map, prefix + "EngineVersion", this.EngineVersion);
            this.SetParamSimple(map, prefix + "Brief", this.Brief);
            this.SetParamSimple(map, prefix + "Chief", this.Chief);
            this.SetParamSimple(map, prefix + "DBA", this.DBA);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "WorkerNodeNum", this.WorkerNodeNum);
        }
    }
}

