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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RunJobFlowRequest : AbstractModel
    {
        
        /// <summary>
        /// 作业名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 是否新创建集群。
        /// true，新创建集群，则使用Instance中的参数进行集群创建。
        /// false，使用已有集群，则通过InstanceId传入。
        /// </summary>
        [JsonProperty("CreateCluster")]
        public bool? CreateCluster{ get; set; }

        /// <summary>
        /// 作业流程执行步骤。
        /// </summary>
        [JsonProperty("Steps")]
        public Step[] Steps{ get; set; }

        /// <summary>
        /// 作业流程正常完成时，集群的处理方式，可选择:
        /// Terminate 销毁集群。
        /// Reserve 保留集群。
        /// </summary>
        [JsonProperty("InstancePolicy")]
        public string InstancePolicy{ get; set; }

        /// <summary>
        /// 只有CreateCluster为true时生效，目前只支持EMR版本，例如EMR-2.2.0，不支持ClickHouse和Druid版本。
        /// </summary>
        [JsonProperty("ProductVersion")]
        public string ProductVersion{ get; set; }

        /// <summary>
        /// 只在CreateCluster为true时生效。
        /// true 表示安装kerberos，false表示不安装kerberos。
        /// </summary>
        [JsonProperty("SecurityClusterFlag")]
        public bool? SecurityClusterFlag{ get; set; }

        /// <summary>
        /// 只在CreateCluster为true时生效。
        /// 新建集群时，要安装的软件列表。
        /// </summary>
        [JsonProperty("Software")]
        public string[] Software{ get; set; }

        /// <summary>
        /// 引导脚本。
        /// </summary>
        [JsonProperty("BootstrapActions")]
        public BootstrapAction[] BootstrapActions{ get; set; }

        /// <summary>
        /// 指定配置创建集群。
        /// </summary>
        [JsonProperty("Configurations")]
        public Configuration[] Configurations{ get; set; }

        /// <summary>
        /// 作业日志保存地址。
        /// </summary>
        [JsonProperty("LogUri")]
        public string LogUri{ get; set; }

        /// <summary>
        /// 只在CreateCluster为false时生效。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 自定义应用角色，大数据应用访问外部服务时使用的角色，默认为"EME_QCSRole"。
        /// </summary>
        [JsonProperty("ApplicationRole")]
        public string ApplicationRole{ get; set; }

        /// <summary>
        /// 重入标签，用来可重入检查，防止在一段时间内，创建相同的流程作业。
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// 只在CreateCluster为true时生效，使用该配置创建集群。
        /// </summary>
        [JsonProperty("Instance")]
        public ClusterSetting Instance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CreateCluster", this.CreateCluster);
            this.SetParamArrayObj(map, prefix + "Steps.", this.Steps);
            this.SetParamSimple(map, prefix + "InstancePolicy", this.InstancePolicy);
            this.SetParamSimple(map, prefix + "ProductVersion", this.ProductVersion);
            this.SetParamSimple(map, prefix + "SecurityClusterFlag", this.SecurityClusterFlag);
            this.SetParamArraySimple(map, prefix + "Software.", this.Software);
            this.SetParamArrayObj(map, prefix + "BootstrapActions.", this.BootstrapActions);
            this.SetParamArrayObj(map, prefix + "Configurations.", this.Configurations);
            this.SetParamSimple(map, prefix + "LogUri", this.LogUri);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ApplicationRole", this.ApplicationRole);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamObj(map, prefix + "Instance.", this.Instance);
        }
    }
}

