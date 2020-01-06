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

namespace TencentCloud.Tia.V20180226.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateModelRequest : AbstractModel
    {
        
        /// <summary>
        /// 模型名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 要部署的模型文件路径名
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// 关于模型的描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 部署目标集群的名称，`集群模式` 必填
        /// </summary>
        [JsonProperty("Cluster")]
        public string Cluster{ get; set; }

        /// <summary>
        /// 运行环境镜像的标签，详见 [Serving 环境](https://cloud.tencent.com/document/product/851/17320#serving-.E7.8E.AF.E5.A2.83)
        /// </summary>
        [JsonProperty("RuntimeVersion")]
        public string RuntimeVersion{ get; set; }

        /// <summary>
        /// 要部署的模型副本数目，`集群模式` 选填
        /// </summary>
        [JsonProperty("Replicas")]
        public ulong? Replicas{ get; set; }

        /// <summary>
        /// 暴露外网或内网，默认暴露外网，`集群模式` 选填
        /// </summary>
        [JsonProperty("Expose")]
        public string Expose{ get; set; }

        /// <summary>
        /// 部署模式，取值 `serverless` 即为 `无服务器模式`，否则为 `集群模式` 下服务的运行规模，形如 `2U4G1P`，详见 [自定义的训练规模](https://cloud.tencent.com/document/product/851/17319#.E8.87.AA.E5.AE.9A.E4.B9.89.E7.9A.84.E8.AE.AD.E7.BB.83.E8.A7.84.E6.A8.A1)
        /// </summary>
        [JsonProperty("ServType")]
        public string ServType{ get; set; }

        /// <summary>
        /// `无服务器模式` 可选的其他配置信息，详见 [利用无服务器函数部署](https://cloud.tencent.com/document/product/851/17049#.E5.88.A9.E7.94.A8.E6.97.A0.E6.9C.8D.E5.8A.A1.E5.99.A8.E5.87.BD.E6.95.B0.E9.83.A8.E7.BD.B2)
        /// </summary>
        [JsonProperty("RuntimeConf")]
        public string[] RuntimeConf{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Cluster", this.Cluster);
            this.SetParamSimple(map, prefix + "RuntimeVersion", this.RuntimeVersion);
            this.SetParamSimple(map, prefix + "Replicas", this.Replicas);
            this.SetParamSimple(map, prefix + "Expose", this.Expose);
            this.SetParamSimple(map, prefix + "ServType", this.ServType);
            this.SetParamArraySimple(map, prefix + "RuntimeConf.", this.RuntimeConf);
        }
    }
}

