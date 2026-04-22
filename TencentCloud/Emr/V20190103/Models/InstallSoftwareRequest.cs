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

    public class InstallSoftwareRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集群实例号</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>组件版本号，例如presto-0.161，可根据InstallSoftWareInfo查看当前集群可安装的组件</p>
        /// </summary>
        [JsonProperty("SoftInfo")]
        public string[] SoftInfo{ get; set; }

        /// <summary>
        /// <p>如果需要购买CDB，如果是包年包月集群，是否为这个cdb自动续费，默认AUTO_RENEW,如不自动续费新增的CDB，则填入NOT_AUTO_RENEW</p>
        /// </summary>
        [JsonProperty("CdbAutoRenew")]
        public string CdbAutoRenew{ get; set; }

        /// <summary>
        /// <p>hive共享元数据库类型。取值范围：</p><li>EMR_NEW_META：表示集群默认创建</li><li>EMR_EXIT_METE：表示集群使用指定EMR-MetaDB。</li><li>USER_CUSTOM_META：表示集群使用自定义MetaDB。</li>
        /// </summary>
        [JsonProperty("MetaType")]
        public string MetaType{ get; set; }

        /// <summary>
        /// <p>EMR-MetaDB实例</p>
        /// </summary>
        [JsonProperty("UnifyMetaInstanceId")]
        public string UnifyMetaInstanceId{ get; set; }

        /// <summary>
        /// <p>自定义MetaDB信息</p>
        /// </summary>
        [JsonProperty("MetaDBInfo")]
        public CustomMetaInfo MetaDBInfo{ get; set; }

        /// <summary>
        /// <p>共用组件信息</p>
        /// </summary>
        [JsonProperty("ExternalService")]
        public ExternalService[] ExternalService{ get; set; }

        /// <summary>
        /// <p>标签信息</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>角色的Pod规格信息</p>
        /// </summary>
        [JsonProperty("CloudResources")]
        public CloudResource[] CloudResources{ get; set; }

        /// <summary>
        /// <p>自定义部署信息</p>
        /// </summary>
        [JsonProperty("ServiceDeployInfoList")]
        public ServiceDeployInfo[] ServiceDeployInfoList{ get; set; }

        /// <summary>
        /// <p>数据库版本</p>
        /// </summary>
        [JsonProperty("DefaultMetaVersion")]
        public string DefaultMetaVersion{ get; set; }

        /// <summary>
        /// <p>是否开通审计</p>
        /// </summary>
        [JsonProperty("NeedCdbAudit")]
        public long? NeedCdbAudit{ get; set; }

        /// <summary>
        /// <p>额外容器相关配置</p>
        /// </summary>
        [JsonProperty("ContainerExtraConf")]
        public ContainerExtraConf ContainerExtraConf{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "SoftInfo.", this.SoftInfo);
            this.SetParamSimple(map, prefix + "CdbAutoRenew", this.CdbAutoRenew);
            this.SetParamSimple(map, prefix + "MetaType", this.MetaType);
            this.SetParamSimple(map, prefix + "UnifyMetaInstanceId", this.UnifyMetaInstanceId);
            this.SetParamObj(map, prefix + "MetaDBInfo.", this.MetaDBInfo);
            this.SetParamArrayObj(map, prefix + "ExternalService.", this.ExternalService);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArrayObj(map, prefix + "CloudResources.", this.CloudResources);
            this.SetParamArrayObj(map, prefix + "ServiceDeployInfoList.", this.ServiceDeployInfoList);
            this.SetParamSimple(map, prefix + "DefaultMetaVersion", this.DefaultMetaVersion);
            this.SetParamSimple(map, prefix + "NeedCdbAudit", this.NeedCdbAudit);
            this.SetParamObj(map, prefix + "ContainerExtraConf.", this.ContainerExtraConf);
        }
    }
}

