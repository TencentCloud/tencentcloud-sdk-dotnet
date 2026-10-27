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

namespace TencentCloud.Cvd.V20201104.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例类型。<li>  S3L.MEDIUM4: 云桌面-标准S3_2核4G </li><li> S3L.LARGE8: 云桌面-标准S3_4核8G </li><li> S3L.LARGE16: 云桌面-标准S3_4核16G </li><li> S3L.2XLARGE16: 云桌面-标准S3_8核16G </li><li> S1L.LARGE8：云桌面-标准S1_4核8G </li><li> S1L.LARGE16：标准S1_4核16G </li><li> S2L.2XLARGE16：标准S2_8核16G </li><li> G1L.LARGE16：图形G1_4核16G  </li><li> G1L.2XLARGE32：图形G1_8核32G </li><li> G1L.4XLARGE64：图形G1_16核64G </li><li> G2L.LARGE24: 云桌面-图形G2_6核24G </li><li> G2L.3XLARGE58: 云桌面-图形G2_14核58G </li><li> G2L.3XLARGE44: 云桌面-图形G2_12核44G </li><li> G3L.LARGE16: 云桌面-图形G3_4核16G </li><li> G3L.5XMEDIUM40: 云桌面-图形G3_10核40G </li><li> G3L.5XLARGE80: 云桌面-图形G3_20核80G </li><li> G4L.5XMEDIUM40: 云桌面-图形G4_10核40G </li><li> G4L.11XMEDIUM80: 云桌面-图形G4_22核80G </li><li> G4L.11XLARGE160: 云桌面-图形G4_44核160G </li><li> G5L.5XMEDIUM40: 云桌面-图形G5_10核40G </li><li> G5L.5XLARGE80: 云桌面-图形G5_22核80G </li><li> G5L.21XMEDIUM160: 云桌面-图形G5_42核160G </li><li> G5L.21XLARGE320: 云桌面-图形G5_84核320G </li>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 系统盘信息
        /// </summary>
        [JsonProperty("SystemDisk")]
        public Disk SystemDisk{ get; set; }

        /// <summary>
        /// 镜像ID
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// 私有网络相关信息配置。通过该参数可以指定私有网络的ID，子网ID等信息。
        /// </summary>
        [JsonProperty("VirtualPrivateCloud")]
        public VirtualPrivateCloud VirtualPrivateCloud{ get; set; }

        /// <summary>
        /// 实例显示名称。
        /// <li> 如果该字段为空，则采用默认格式：云桌面型号+月日+三位随机数+镜像ID。</li>
        /// <li> 购买多台实例，如果指定模式串{R:x}，表示生成数字[x, x+n-1]，其中n表示购买实例的数量，例如server_{R:3}，购买1台时，实例显示名称为server_3；购买2台时，实例显示名称分别为server_3，server_4。支持指定多个模式串{R:x}。</li>
        /// <li> 购买多台实例，如果不指定模式串，则在实例显示名称添加后缀1、2...n，其中n表示购买实例的数量，例如server_，购买2台时，实例显示名称分别为server_1，server_2。</li>
        /// <li> 最多支持60个字符（包含模式串）。</li>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 购买实例数量。取值范围[1,50]。默认为1
        /// </summary>
        [JsonProperty("InstanceCount")]
        public ulong? InstanceCount{ get; set; }

        /// <summary>
        /// 数据盘信息。目前只支持一块数据盘。
        /// </summary>
        [JsonProperty("DataDisks")]
        public Disk[] DataDisks{ get; set; }

        /// <summary>
        /// 实例计费类型。
        /// <li> PREPAID：预付费，即包年包月</li>
        /// <li> POSTPAID_BY_HOUR：按小时后付费</li>
        /// 默认为PREPAID
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// 预付费模式，即包年包月相关参数设置。通过该参数可以指定包年包月实例的购买时长、是否设置自动续费等属性。若指定实例的付费模式为预付费则该参数必传。
        /// </summary>
        [JsonProperty("ChargePrepaid")]
        public ChargePrepaid ChargePrepaid{ get; set; }

        /// <summary>
        /// 是否只预检此次请求。
        /// <li> true：发送检查请求，不会创建实例。检查项包括是否填写了必需参数，请求格式，业务限制和库存。
        /// 如果检查通过，则返回的错误码为DryRunOperation；如果返回其他错误码表示检查没有通过；</li>
        /// <li> false（默认）：发送正常请求，通过检查后直接创建实例</li>
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// 允许绑定用户前的匿名访问。默认值：false。
        /// </summary>
        [JsonProperty("AnonymousAccess")]
        public bool? AnonymousAccess{ get; set; }

        /// <summary>
        /// 关联的安全组ID列表
        /// </summary>
        [JsonProperty("SecurityGroups")]
        public string[] SecurityGroups{ get; set; }

        /// <summary>
        /// 桌面池ID
        /// </summary>
        [JsonProperty("PoolId")]
        public string PoolId{ get; set; }

        /// <summary>
        /// 域名管控策略ID
        /// </summary>
        [JsonProperty("DomainControlPolicies")]
        public string[] DomainControlPolicies{ get; set; }

        /// <summary>
        /// 标签，最多10个
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamObj(map, prefix + "VirtualPrivateCloud.", this.VirtualPrivateCloud);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamArrayObj(map, prefix + "DataDisks.", this.DataDisks);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamObj(map, prefix + "ChargePrepaid.", this.ChargePrepaid);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamSimple(map, prefix + "AnonymousAccess", this.AnonymousAccess);
            this.SetParamArraySimple(map, prefix + "SecurityGroups.", this.SecurityGroups);
            this.SetParamSimple(map, prefix + "PoolId", this.PoolId);
            this.SetParamArraySimple(map, prefix + "DomainControlPolicies.", this.DomainControlPolicies);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
        }
    }
}

