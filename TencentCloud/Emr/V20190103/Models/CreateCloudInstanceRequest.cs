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

    public class CreateCloudInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例名称。
        /// <li>长度限制为6-36个字符。</li>
        /// <li>只允许包含中文、字母、数字、-、_。</li>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 容器集群类型，取值范围
        /// <li>EMR容器集群实例: EMR-TKE</li>
        /// </summary>
        [JsonProperty("ClusterClass")]
        public string ClusterClass{ get; set; }

        /// <summary>
        /// 部署的组件列表，不同的EMR产品ID（ProductId：具体含义参考入参ProductId字段）对应不同可选组件列表，不同产品版本可选组件列表查询：[组件版本](https://cloud.tencent.com/document/product/589/20279) ；
        /// </summary>
        [JsonProperty("Software")]
        public string[] Software{ get; set; }

        /// <summary>
        /// 容器平台类型，取值范围
        /// <li>EMR容器集群实例: tke</li>
        /// </summary>
        [JsonProperty("PlatFormType")]
        public string PlatFormType{ get; set; }

        /// <summary>
        /// cos存储桶
        /// </summary>
        [JsonProperty("CosBucket")]
        public string CosBucket{ get; set; }

        /// <summary>
        /// 容器集群id
        /// </summary>
        [JsonProperty("EksClusterId")]
        public string EksClusterId{ get; set; }

        /// <summary>
        /// 产品Id，不同产品ID表示不同的EMR产品版本。取值范围：
        /// <li>60:表示EMR-TKE-V1.1.0</li>
        /// <li>55:表示EMR-TKE-V1.0.1</li>
        /// <li>52:表示EMR-TKE-V1.0.0</li>
        /// </summary>
        [JsonProperty("ProductId")]
        public long? ProductId{ get; set; }

        /// <summary>
        /// 客户端token，唯一随机标识，时效5分钟，需要调用者指定 防止客户端重新创建资源，小于等于64个字符，例如 a9a90aa6fae36063280
        /// 示例值：a9a90aa6fae36063280
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// 私有网络相关信息配置。通过该参数可以指定私有网络的ID，子网ID等信息。
        /// </summary>
        [JsonProperty("VPCSettings")]
        public VPCSettings VPCSettings{ get; set; }

        /// <summary>
        /// 所有组件角色及其对应的Pod资源请求信息
        /// </summary>
        [JsonProperty("CloudResources")]
        public CloudResource[] CloudResources{ get; set; }

        /// <summary>
        /// 安全组Id，为空默认创建新的安全组
        /// </summary>
        [JsonProperty("SgId")]
        public string SgId{ get; set; }

        /// <summary>
        /// 元数据库信息
        /// MetaDB信息，当MetaType选择EMR_NEW_META时，MetaDataJdbcUrl MetaDataUser MetaDataPass UnifyMetaInstanceId不用填
        /// 当MetaType选择EMR_EXIT_META时，填写UnifyMetaInstanceId
        /// 当MetaType选择USER_CUSTOM_META时，填写MetaDataJdbcUrl MetaDataUser MetaDataPass
        /// </summary>
        [JsonProperty("MetaDBInfo")]
        public CustomMetaDBInfo MetaDBInfo{ get; set; }

        /// <summary>
        /// 标签信息
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 登录密码，LoginSettings中的Password字段
        /// </summary>
        [JsonProperty("LoginSettings")]
        public LoginSettings LoginSettings{ get; set; }

        /// <summary>
        /// 共享服务信息
        /// </summary>
        [JsonProperty("ExternalService")]
        public ExternalService[] ExternalService{ get; set; }

        /// <summary>
        /// 可用区id
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// 数据库版本
        /// </summary>
        [JsonProperty("DefaultMetaVersion")]
        public string DefaultMetaVersion{ get; set; }

        /// <summary>
        /// 是否开通审计
        /// </summary>
        [JsonProperty("NeedCdbAudit")]
        public long? NeedCdbAudit{ get; set; }

        /// <summary>
        /// 安全组来源IP
        /// </summary>
        [JsonProperty("SgIP")]
        public string SgIP{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "ClusterClass", this.ClusterClass);
            this.SetParamArraySimple(map, prefix + "Software.", this.Software);
            this.SetParamSimple(map, prefix + "PlatFormType", this.PlatFormType);
            this.SetParamSimple(map, prefix + "CosBucket", this.CosBucket);
            this.SetParamSimple(map, prefix + "EksClusterId", this.EksClusterId);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamObj(map, prefix + "VPCSettings.", this.VPCSettings);
            this.SetParamArrayObj(map, prefix + "CloudResources.", this.CloudResources);
            this.SetParamSimple(map, prefix + "SgId", this.SgId);
            this.SetParamObj(map, prefix + "MetaDBInfo.", this.MetaDBInfo);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "LoginSettings.", this.LoginSettings);
            this.SetParamArrayObj(map, prefix + "ExternalService.", this.ExternalService);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "DefaultMetaVersion", this.DefaultMetaVersion);
            this.SetParamSimple(map, prefix + "NeedCdbAudit", this.NeedCdbAudit);
            this.SetParamSimple(map, prefix + "SgIP", this.SgIP);
        }
    }
}

