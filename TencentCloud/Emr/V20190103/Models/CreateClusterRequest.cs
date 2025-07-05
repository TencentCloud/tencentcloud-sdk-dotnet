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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateClusterRequest : AbstractModel
    {
        
        /// <summary>
        /// EMR产品版本名称如EMR-V2.3.0 表示2.3.0版本的EMR， 当前支持产品版本名称查询：[产品版本名称](https://cloud.tencent.com/document/product/589/66338)
        /// </summary>
        [JsonProperty("ProductVersion")]
        public string ProductVersion{ get; set; }

        /// <summary>
        /// 是否开启节点高可用。取值范围：
        /// <li>true：表示开启节点高可用。</li>
        /// <li>false：表示不开启节点高可用。</li>
        /// </summary>
        [JsonProperty("EnableSupportHAFlag")]
        public bool? EnableSupportHAFlag{ get; set; }

        /// <summary>
        /// 实例名称。
        /// <li>长度限制为6-36个字符。</li>
        /// <li>只允许包含中文、字母、数字、-、_。</li>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 实例计费模式。取值范围：
        /// <li>PREPAID：预付费，即包年包月。</li>
        /// <li>POSTPAID_BY_HOUR：按小时后付费。</li>
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// 实例登录设置。通过该参数可以设置所购买节点的登录方式密码或者密钥。
        /// <li>设置密钥时，密码仅用于组件原生WebUI快捷入口登录。</li>
        /// <li>未设置密钥时，密码用于登录所购节点以及组件原生WebUI快捷入口登录。</li>
        /// </summary>
        [JsonProperty("LoginSettings")]
        public LoginSettings LoginSettings{ get; set; }

        /// <summary>
        /// 集群应用场景以及支持部署组件配置
        /// </summary>
        [JsonProperty("SceneSoftwareConfig")]
        public SceneSoftwareConfig SceneSoftwareConfig{ get; set; }

        /// <summary>
        /// 即包年包月相关参数设置。通过该参数可以指定包年包月实例的购买时长、是否设置自动续费等属性。若指定实例的付费模式为预付费则该参数必传。
        /// </summary>
        [JsonProperty("InstanceChargePrepaid")]
        public InstanceChargePrepaid InstanceChargePrepaid{ get; set; }

        /// <summary>
        /// 实例所属安全组的ID，形如sg-xxxxxxxx。该参数可以通过调用 [DescribeSecurityGroups](https://cloud.tencent.com/document/api/215/15808) 的返回值中的SecurityGroupId字段来获取。
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// [引导操作](https://cloud.tencent.com/document/product/589/35656)脚本设置。
        /// </summary>
        [JsonProperty("ScriptBootstrapActionConfig")]
        public ScriptBootstrapActionConfig[] ScriptBootstrapActionConfig{ get; set; }

        /// <summary>
        /// 唯一随机标识，时效性为5分钟，需要调用者指定 防止客户端重复创建资源，例如 a9a90aa6-****-****-****-fae360632808
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// 是否开启集群Master节点公网。取值范围：
        /// <li>NEED_MASTER_WAN：表示开启集群Master节点公网。</li>
        /// <li>NOT_NEED_MASTER_WAN：表示不开启。</li>默认开启集群Master节点公网。
        /// </summary>
        [JsonProperty("NeedMasterWan")]
        public string NeedMasterWan{ get; set; }

        /// <summary>
        /// 是否开启外网远程登录。（在SecurityGroupId不为空时，该参数无效）不填默认为不开启 取值范围：
        /// <li>true：表示开启</li>
        /// <li>false：表示不开启</li>
        /// </summary>
        [JsonProperty("EnableRemoteLoginFlag")]
        public bool? EnableRemoteLoginFlag{ get; set; }

        /// <summary>
        /// 是否开启Kerberos认证。默认不开启 取值范围：
        /// <li>true：表示开启</li>
        /// <li>false：表示不开启</li>
        /// </summary>
        [JsonProperty("EnableKerberosFlag")]
        public bool? EnableKerberosFlag{ get; set; }

        /// <summary>
        /// [自定义软件配置](https://cloud.tencent.com/document/product/589/35655?from_cn_redirect=1)
        /// </summary>
        [JsonProperty("CustomConf")]
        public string CustomConf{ get; set; }

        /// <summary>
        /// 标签描述列表。通过指定该参数可以同时绑定标签到相应的实例。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 分散置放群组ID列表，当前只支持指定一个。
        /// 该参数可以通过调用 [DescribeDisasterRecoverGroups](https://cloud.tencent.com/document/product/213/17810)的返回值中的DisasterRecoverGroupId字段来获取。
        /// </summary>
        [JsonProperty("DisasterRecoverGroupIds")]
        public string[] DisasterRecoverGroupIds{ get; set; }

        /// <summary>
        /// 是否开启集群维度CBS加密。默认不加密 取值范围：
        /// <li>true：表示加密</li>
        /// <li>false：表示不加密</li>
        /// </summary>
        [JsonProperty("EnableCbsEncryptFlag")]
        public bool? EnableCbsEncryptFlag{ get; set; }

        /// <summary>
        /// MetaDB信息，当MetaType选择EMR_NEW_META时，MetaDataJdbcUrl MetaDataUser MetaDataPass UnifyMetaInstanceId不用填
        /// 当MetaType选择EMR_EXIT_META时，填写UnifyMetaInstanceId
        /// 当MetaType选择USER_CUSTOM_META时，填写MetaDataJdbcUrl MetaDataUser MetaDataPass
        /// </summary>
        [JsonProperty("MetaDBInfo")]
        public CustomMetaDBInfo MetaDBInfo{ get; set; }

        /// <summary>
        /// 共享组件信息
        /// </summary>
        [JsonProperty("DependService")]
        public DependService[] DependService{ get; set; }

        /// <summary>
        /// 节点资源的规格，有几个可用区，就填几个，按顺序第一个为主可用区，第二个为备可用区，第三个为仲裁可用区。如果没有开启跨AZ，则长度为1即可。
        /// </summary>
        [JsonProperty("ZoneResourceConfiguration")]
        public ZoneResourceConfiguration[] ZoneResourceConfiguration{ get; set; }

        /// <summary>
        /// cos桶路径，创建StarRocks存算分离集群时用到
        /// </summary>
        [JsonProperty("CosBucket")]
        public string CosBucket{ get; set; }

        /// <summary>
        /// 节点标识信息，目前只提供给tf平台使用
        /// </summary>
        [JsonProperty("NodeMarks")]
        public NodeMark[] NodeMarks{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductVersion", this.ProductVersion);
            this.SetParamSimple(map, prefix + "EnableSupportHAFlag", this.EnableSupportHAFlag);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamObj(map, prefix + "LoginSettings.", this.LoginSettings);
            this.SetParamObj(map, prefix + "SceneSoftwareConfig.", this.SceneSoftwareConfig);
            this.SetParamObj(map, prefix + "InstanceChargePrepaid.", this.InstanceChargePrepaid);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamArrayObj(map, prefix + "ScriptBootstrapActionConfig.", this.ScriptBootstrapActionConfig);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamSimple(map, prefix + "NeedMasterWan", this.NeedMasterWan);
            this.SetParamSimple(map, prefix + "EnableRemoteLoginFlag", this.EnableRemoteLoginFlag);
            this.SetParamSimple(map, prefix + "EnableKerberosFlag", this.EnableKerberosFlag);
            this.SetParamSimple(map, prefix + "CustomConf", this.CustomConf);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArraySimple(map, prefix + "DisasterRecoverGroupIds.", this.DisasterRecoverGroupIds);
            this.SetParamSimple(map, prefix + "EnableCbsEncryptFlag", this.EnableCbsEncryptFlag);
            this.SetParamObj(map, prefix + "MetaDBInfo.", this.MetaDBInfo);
            this.SetParamArrayObj(map, prefix + "DependService.", this.DependService);
            this.SetParamArrayObj(map, prefix + "ZoneResourceConfiguration.", this.ZoneResourceConfiguration);
            this.SetParamSimple(map, prefix + "CosBucket", this.CosBucket);
            this.SetParamArrayObj(map, prefix + "NodeMarks.", this.NodeMarks);
        }
    }
}

