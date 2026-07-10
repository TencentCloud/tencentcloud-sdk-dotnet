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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModelKeyInfoItem : AbstractModel
    {
        
        /// <summary>
        /// <p>接入类型</p>
        /// </summary>
        [JsonProperty("AccessType")]
        public string AccessType{ get; set; }

        /// <summary>
        /// <p>API Base URL</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiBase")]
        public string ApiBase{ get; set; }

        /// <summary>
        /// <p>模型创建时间（ISO 8601）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// <p>自定义host header</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HostHeader")]
        public string HostHeader{ get; set; }

        /// <summary>
        /// <p>Key 数量</p>
        /// </summary>
        [JsonProperty("KeyCount")]
        public long? KeyCount{ get; set; }

        /// <summary>
        /// <p>Key 详情列表</p>
        /// </summary>
        [JsonProperty("Keys")]
        public KeyDetailItem[] Keys{ get; set; }

        /// <summary>
        /// <p>model信息</p>
        /// </summary>
        [JsonProperty("ModelIdsWithAlias")]
        public ServiceProviderModelItem[] ModelIdsWithAlias{ get; set; }

        /// <summary>
        /// <p>模型供应商</p>
        /// </summary>
        [JsonProperty("ModelProvider")]
        public string ModelProvider{ get; set; }

        /// <summary>
        /// <p>模型协议</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>内部通信占用IP</p>
        /// </summary>
        [JsonProperty("ServiceIps")]
        public string[] ServiceIps{ get; set; }

        /// <summary>
        /// <p>服务提供商ID</p>
        /// </summary>
        [JsonProperty("ServiceProviderId")]
        public string ServiceProviderId{ get; set; }

        /// <summary>
        /// <p>服务提供商自定义名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceProviderName")]
        public string ServiceProviderName{ get; set; }

        /// <summary>
        /// <p>模型状态</p><p>枚举值：</p><ul><li>Active： 运行中</li><li>Provisioning： 创建中</li><li>Configuring： 变配中</li><li>Deleting： 删除中</li><li>ProvisionFailed： 创建失败</li><li>ConfigureFailed： 变配失败</li><li>DeletionFailed： 删除失败</li><li>Disabled： 已禁用</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>子网 ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>标签信息</p>
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// <p>是否校验上游SSL</p>
        /// </summary>
        [JsonProperty("VerifySSL")]
        public bool? VerifySSL{ get; set; }

        /// <summary>
        /// <p>VPC 实例 ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamSimple(map, prefix + "ApiBase", this.ApiBase);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "HostHeader", this.HostHeader);
            this.SetParamSimple(map, prefix + "KeyCount", this.KeyCount);
            this.SetParamArrayObj(map, prefix + "Keys.", this.Keys);
            this.SetParamArrayObj(map, prefix + "ModelIdsWithAlias.", this.ModelIdsWithAlias);
            this.SetParamSimple(map, prefix + "ModelProvider", this.ModelProvider);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamArraySimple(map, prefix + "ServiceIps.", this.ServiceIps);
            this.SetParamSimple(map, prefix + "ServiceProviderId", this.ServiceProviderId);
            this.SetParamSimple(map, prefix + "ServiceProviderName", this.ServiceProviderName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "VerifySSL", this.VerifySSL);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
        }
    }
}

