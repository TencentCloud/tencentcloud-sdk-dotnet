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

namespace TencentCloud.Oceanus.V20190422.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateOceanusClusterRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集群名称</p><p>入参限制：支持1-50个英文、汉字、数字、连接线-或下划线_</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>地域Id，可通过地域管理系统<a href="https://cloud.tencent.com/document/api/1596/77930"> DescribeRegions</a>查询Product参数设置 oceanus</p>
        /// </summary>
        [JsonProperty("RegionId")]
        public long? RegionId{ get; set; }

        /// <summary>
        /// <p>可用区Id，可通过地域管理系统<a href="https://cloud.tencent.com/document/api/1596/77929"> DescribeZones</a>查询<br>Product参数设置 oceanus</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// <p>FlinkUI访问密码</p><p>用户名与密码将用于登录查看作业的 Flink UI 界面，集群用户名:admin</p>
        /// </summary>
        [JsonProperty("LoginPassword")]
        public string LoginPassword{ get; set; }

        /// <summary>
        /// <p>流计算通过 VPC 和弹性网卡来访问同地域中的其他云产品资源，并需要占用一定的子网 IP 数量，请确保所选子网的可用 IP 数量充足 如现有网络不符合您的要求，请前往 VPC 控制台<a href="https://console.cloud.tencent.com/vpc/vpc?rid=undefined">新建私有网络</a> 或 <a href="https://console.cloud.tencent.com/vpc/subnet?rid=undefined">新建子网</a></p>
        /// </summary>
        [JsonProperty("VpcDescriptions")]
        public VPCDescription[] VpcDescriptions{ get; set; }

        /// <summary>
        /// <p>流计算使用对象存储 COS 来保存作业的 checkpoint、jar 包、或投递日志等，如本地域无可用存储桶，请前往<a href="https://console.cloud.tencent.com/cos5">对象存储控制台</a>新建 为了保证您的正常使用，对应COS的生命周期配置请参考<a href="https://cloud.tencent.com/document/product/436/33417?from=console_document_search">文档</a></p>
        /// </summary>
        [JsonProperty("DefaultCOSBucket")]
        public string DefaultCOSBucket{ get; set; }

        /// <summary>
        /// <p>集群CU数， 12 CU 是流计算的最小计算资源和计费单位，1CU 包含1个 CPU 和 4GB 内存。 当CU数大于等于 48 时，减免管理节点费用。</p>
        /// </summary>
        [JsonProperty("CU")]
        public long? CU{ get; set; }

        /// <summary>
        /// <p>集群描述</p><p>入参限制：支持1-50个英文、汉字、数字、连接线-或下划线_</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>购买时长，以月为单位</p><p>取值范围：[1, 48]</p>
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// <p>集群计费类型</p><p>枚举值：</p><ul><li>PREPAID： 包年包月</li><li>POSTPAID_BY_SECOND： 按量计费</li></ul><p>默认值：POSTPAID_BY_SECOND</p>
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// <p>集群类型</p><p>枚举值：</p><ul><li>MULTI_AZ_CLUSTER： 多可用区集群</li></ul>
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// <p>自动续费标识</p><p>枚举值：</p><ul><li>NOTIFY_AND_MANUAL_RENEW： 通知并手动续费</li><li>NOTIFY_AND_AUTO_RENEW： 通知并自动续费</li><li>DISABLE_NOTIFY_AND_MANUAL_RENEW： 不通知并不自动续费</li></ul><p>默认值：NOTIFY_AND_MANUAL_RENEW</p><p>InstanceChargeType设置PREPAID时，对应包年包月集群，需要设置自动续费标识，按量计费集群不需要设置</p>
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// <p>Flink UI访问类型设置</p><p>枚举值：</p><ul><li>NetworkAccess_INTERNAL： 内网访问</li><li>NetworkAccess_EXTERNAL： 公网访问</li></ul><p>默认值：NetworkAccess_EXTERNAL</p>
        /// </summary>
        [JsonProperty("FlinkWebUINetworkAccessType")]
        public string FlinkWebUINetworkAccessType{ get; set; }

        /// <summary>
        /// <p>多可用区VPC</p>
        /// </summary>
        [JsonProperty("SlaveVpcDescriptions")]
        public SlaveVpcDescriptions[] SlaveVpcDescriptions{ get; set; }

        /// <summary>
        /// <p>核心内存比值，只支持 [0，2，4，8]</p>
        /// </summary>
        [JsonProperty("CUMemory")]
        public long? CUMemory{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "LoginPassword", this.LoginPassword);
            this.SetParamArrayObj(map, prefix + "VpcDescriptions.", this.VpcDescriptions);
            this.SetParamSimple(map, prefix + "DefaultCOSBucket", this.DefaultCOSBucket);
            this.SetParamSimple(map, prefix + "CU", this.CU);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "FlinkWebUINetworkAccessType", this.FlinkWebUINetworkAccessType);
            this.SetParamArrayObj(map, prefix + "SlaveVpcDescriptions.", this.SlaveVpcDescriptions);
            this.SetParamSimple(map, prefix + "CUMemory", this.CUMemory);
        }
    }
}

