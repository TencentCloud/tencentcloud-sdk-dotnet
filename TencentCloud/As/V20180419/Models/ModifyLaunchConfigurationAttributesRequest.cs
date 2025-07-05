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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyLaunchConfigurationAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// 启动配置ID。可通过登录 [控制台](https://console.cloud.tencent.com/autoscaling/config) 或调用接口 [DescribeLaunchConfigurations](https://cloud.tencent.com/document/api/377/20445) ，取返回信息中的 LaunchConfigurationId 获取启动配置ID。
        /// </summary>
        [JsonProperty("LaunchConfigurationId")]
        public string LaunchConfigurationId{ get; set; }

        /// <summary>
        /// 指定有效的[镜像](https://cloud.tencent.com/document/product/213/4940)ID，格式形如`img-8toqc6s3`。镜像类型分为四种：<br/><li>公共镜像</li><li>自定义镜像</li><li>共享镜像</li><li>服务市场镜像</li><br/>可通过以下方式获取可用的镜像ID：<br/><li>`公共镜像`、`自定义镜像`、`共享镜像`的镜像ID可通过登录[控制台](https://console.cloud.tencent.com/cvm/image?rid=1&imageType=PUBLIC_IMAGE)查询；`服务镜像市场`的镜像ID可通过[云市场](https://market.cloud.tencent.com/list)查询。</li><li>通过调用接口 [DescribeImages](https://cloud.tencent.com/document/api/213/15715) ，取返回信息中的`ImageId`字段。</li>
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// 实例类型列表，不同实例机型指定了不同的资源规格，最多支持10种实例机型。
        /// InstanceType 指定单一实例类型，通过设置 InstanceTypes可以指定多实例类型，并使原有的InstanceType失效。具体取值可通过调用接口[DescribeInstanceTypeConfigs](https://cloud.tencent.com/document/api/213/15749)来获得最新的规格表或参见[实例规格描述](https://cloud.tencent.com/document/product/213/11518)。
        /// </summary>
        [JsonProperty("InstanceTypes")]
        public string[] InstanceTypes{ get; set; }

        /// <summary>
        /// 实例类型校验策略，在实际修改 InstanceTypes 时发挥作用，取值包括 ALL 和 ANY，默认取值为ANY。
        /// <li> ALL，所有实例类型（InstanceType）都可用则通过校验，否则校验报错。</li> 
        /// <li> ANY，存在任何一个实例类型（InstanceType）可用则通过校验，否则校验报错。</li> 
        /// 实例类型不可用的常见原因包括该实例类型售罄、对应云盘售罄等。
        /// 如果 InstanceTypes 中一款机型不存在或者已下线，则无论 InstanceTypesCheckPolicy 采用何种取值，都会校验报错。
        /// </summary>
        [JsonProperty("InstanceTypesCheckPolicy")]
        public string InstanceTypesCheckPolicy{ get; set; }

        /// <summary>
        /// 启动配置显示名称。名称仅支持中文、英文、数字、下划线、分隔符"-"、小数点，最大长度不能超60个字节。
        /// </summary>
        [JsonProperty("LaunchConfigurationName")]
        public string LaunchConfigurationName{ get; set; }

        /// <summary>
        /// 经过 Base64 编码后的自定义数据，最大长度不超过16KB。如果要清空UserData，则指定其为空字符串。
        /// </summary>
        [JsonProperty("UserData")]
        public string UserData{ get; set; }

        /// <summary>
        /// 实例所属安全组。该参数可以通过调用 [DescribeSecurityGroups](https://cloud.tencent.com/document/api/215/15808) 的返回值中的`SecurityGroupId`字段来获取。
        /// 若指定该参数，请至少提供一个安全组，列表顺序有先后。
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// 公网带宽相关信息设置。
        /// 当公网出带宽上限为0Mbps时，不支持修改为开通分配公网IP；相应的，当前为开通分配公网IP时，修改的公网出带宽上限值必须大于0Mbps。
        /// </summary>
        [JsonProperty("InternetAccessible")]
        public InternetAccessible InternetAccessible{ get; set; }

        /// <summary>
        /// 实例计费类型。具体取值范围如下：
        /// <li>POSTPAID_BY_HOUR：按小时后付费</li>
        /// <li>SPOTPAID：竞价付费</li>
        /// <li>PREPAID：预付费，即包年包月</li>
        /// <li>CDCPAID：专用集群付费</li>
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// 预付费模式，即包年包月相关参数设置。通过该参数可以指定包年包月实例的购买时长、是否设置自动续费等属性。
        /// 若修改实例的付费模式为预付费，则该参数必传；从预付费修改为其他付费模式时，本字段原信息会自动丢弃。
        /// 当新增该字段时，必须传递购买实例的时长，其它未传递字段会设置为默认值。
        /// 当修改本字段时，当前付费模式必须为预付费。
        /// </summary>
        [JsonProperty("InstanceChargePrepaid")]
        public InstanceChargePrepaid InstanceChargePrepaid{ get; set; }

        /// <summary>
        /// 实例的市场相关选项，如竞价实例相关参数。
        /// 若修改实例的付费模式为竞价付费，则该参数必传；从竞价付费修改为其他付费模式时，本字段原信息会自动丢弃。
        /// 当新增该字段时，必须传递竞价相关选项下的竞价出价，其它未传递字段会设置为默认值。
        /// 当修改本字段时，当前付费模式必须为竞价付费。
        /// </summary>
        [JsonProperty("InstanceMarketOptions")]
        public InstanceMarketOptionsRequest InstanceMarketOptions{ get; set; }

        /// <summary>
        /// 云盘类型选择策略，取值范围：
        /// <li>ORIGINAL：使用设置的云盘类型。</li>
        /// <li>AUTOMATIC：自动选择当前可用的云盘类型。</li>
        /// </summary>
        [JsonProperty("DiskTypePolicy")]
        public string DiskTypePolicy{ get; set; }

        /// <summary>
        /// 实例系统盘配置信息。
        /// </summary>
        [JsonProperty("SystemDisk")]
        public SystemDisk SystemDisk{ get; set; }

        /// <summary>
        /// 实例数据盘配置信息。
        /// 最多支持指定11块数据盘。采取整体修改，因此请提供修改后的全部值。
        /// 数据盘类型默认与系统盘类型保持一致。
        /// </summary>
        [JsonProperty("DataDisks")]
        public DataDisk[] DataDisks{ get; set; }

        /// <summary>
        /// 云服务器主机名（HostName）的相关设置。
        /// 不支持windows实例设置主机名。
        /// 新增该属性时，必须传递云服务器的主机名，其它未传递字段会设置为默认值。
        /// </summary>
        [JsonProperty("HostNameSettings")]
        public HostNameSettings HostNameSettings{ get; set; }

        /// <summary>
        /// 云服务器（InstanceName）实例名的相关设置。 
        /// 如果用户在启动配置中设置此字段，则伸缩组创建出的实例 InstanceName 参照此字段进行设置，并传递给 CVM；如果用户未在启动配置中设置此字段，则伸缩组创建出的实例 InstanceName 按照“as-{{ 伸缩组AutoScalingGroupName }}”进行设置，并传递给 CVM。
        /// 新增该属性时，必须传递云服务器的实例名称，其它未传递字段会设置为默认值。
        /// </summary>
        [JsonProperty("InstanceNameSettings")]
        public InstanceNameSettings InstanceNameSettings{ get; set; }

        /// <summary>
        /// 增强服务。通过该参数可以指定是否开启云安全、云监控等服务。
        /// </summary>
        [JsonProperty("EnhancedService")]
        public EnhancedService EnhancedService{ get; set; }

        /// <summary>
        /// CAM角色名称。可通过[DescribeRoleList](https://cloud.tencent.com/document/product/598/36223)接口返回值中的roleName获取。
        /// </summary>
        [JsonProperty("CamRoleName")]
        public string CamRoleName{ get; set; }

        /// <summary>
        /// 高性能计算集群ID。可通过调用[DescribeHpcClusters](https://cloud.tencent.com/document/product/213/83220)接口获取该参数。
        /// 注意：此字段默认为空。
        /// </summary>
        [JsonProperty("HpcClusterId")]
        public string HpcClusterId{ get; set; }

        /// <summary>
        /// IPv6公网带宽相关信息设置。若新建实例包含IPv6地址，该参数可为新建实例的IPv6地址分配公网带宽。关联启动配置的伸缩组Ipv6AddressCount参数为0时，该参数不会生效。
        /// </summary>
        [JsonProperty("IPv6InternetAccessible")]
        public IPv6InternetAccessible IPv6InternetAccessible{ get; set; }

        /// <summary>
        /// 置放群组id，仅支持指定一个。可通过调用[DescribeDisasterRecoverGroups](https://cloud.tencent.com/document/product/213/17810)接口获取该参数。
        /// </summary>
        [JsonProperty("DisasterRecoverGroupIds")]
        public string[] DisasterRecoverGroupIds{ get; set; }

        /// <summary>
        /// 实例登录设置，包括密码、密钥或保持镜像的原始登录设置。<br>请注意，指定新的登录设置会覆盖原有登录设置。例如，如果您之前使用密码登录，使用该参数将登录设置修改为密钥，则原有密码被清除。
        /// </summary>
        [JsonProperty("LoginSettings")]
        public LoginSettings LoginSettings{ get; set; }

        /// <summary>
        /// 实例标签列表。通过指定该参数，可以为扩容的实例绑定标签。最多支持指定10个标签。
        /// 该参数会覆盖原有的实例标签列表，如需新增标签，需将新标签和原有标签一并传入。
        /// </summary>
        [JsonProperty("InstanceTags")]
        public InstanceTag[] InstanceTags{ get; set; }

        /// <summary>
        /// 镜像族名称。可通过调用[DescribeImages](https://cloud.tencent.com/document/product/213/15715)接口获取该参数。
        /// </summary>
        [JsonProperty("ImageFamily")]
        public string ImageFamily{ get; set; }

        /// <summary>
        /// 本地专用集群ID。
        /// </summary>
        [JsonProperty("DedicatedClusterId")]
        public string DedicatedClusterId{ get; set; }

        /// <summary>
        /// 自定义metadata。
        /// </summary>
        [JsonProperty("Metadata")]
        public Metadata Metadata{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LaunchConfigurationId", this.LaunchConfigurationId);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamArraySimple(map, prefix + "InstanceTypes.", this.InstanceTypes);
            this.SetParamSimple(map, prefix + "InstanceTypesCheckPolicy", this.InstanceTypesCheckPolicy);
            this.SetParamSimple(map, prefix + "LaunchConfigurationName", this.LaunchConfigurationName);
            this.SetParamSimple(map, prefix + "UserData", this.UserData);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamObj(map, prefix + "InternetAccessible.", this.InternetAccessible);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamObj(map, prefix + "InstanceChargePrepaid.", this.InstanceChargePrepaid);
            this.SetParamObj(map, prefix + "InstanceMarketOptions.", this.InstanceMarketOptions);
            this.SetParamSimple(map, prefix + "DiskTypePolicy", this.DiskTypePolicy);
            this.SetParamObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamArrayObj(map, prefix + "DataDisks.", this.DataDisks);
            this.SetParamObj(map, prefix + "HostNameSettings.", this.HostNameSettings);
            this.SetParamObj(map, prefix + "InstanceNameSettings.", this.InstanceNameSettings);
            this.SetParamObj(map, prefix + "EnhancedService.", this.EnhancedService);
            this.SetParamSimple(map, prefix + "CamRoleName", this.CamRoleName);
            this.SetParamSimple(map, prefix + "HpcClusterId", this.HpcClusterId);
            this.SetParamObj(map, prefix + "IPv6InternetAccessible.", this.IPv6InternetAccessible);
            this.SetParamArraySimple(map, prefix + "DisasterRecoverGroupIds.", this.DisasterRecoverGroupIds);
            this.SetParamObj(map, prefix + "LoginSettings.", this.LoginSettings);
            this.SetParamArrayObj(map, prefix + "InstanceTags.", this.InstanceTags);
            this.SetParamSimple(map, prefix + "ImageFamily", this.ImageFamily);
            this.SetParamSimple(map, prefix + "DedicatedClusterId", this.DedicatedClusterId);
            this.SetParamObj(map, prefix + "Metadata.", this.Metadata);
        }
    }
}

