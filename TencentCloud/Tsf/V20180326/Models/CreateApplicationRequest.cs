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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateApplicationRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// 应用类型，V：虚拟机应用；C：容器应用；S：serverless应用
        /// </summary>
        [JsonProperty("ApplicationType")]
        public string ApplicationType{ get; set; }

        /// <summary>
        /// 应用微服务类型，M：service mesh应用；N：普通应用；G：网关应用
        /// </summary>
        [JsonProperty("MicroserviceType")]
        public string MicroserviceType{ get; set; }

        /// <summary>
        /// 应用描述
        /// </summary>
        [JsonProperty("ApplicationDesc")]
        public string ApplicationDesc{ get; set; }

        /// <summary>
        /// 应用日志配置项，废弃参数
        /// </summary>
        [JsonProperty("ApplicationLogConfig")]
        public string ApplicationLogConfig{ get; set; }

        /// <summary>
        /// 应用资源类型，废弃参数
        /// </summary>
        [JsonProperty("ApplicationResourceType")]
        public string ApplicationResourceType{ get; set; }

        /// <summary>
        /// 应用runtime类型
        /// </summary>
        [JsonProperty("ApplicationRuntimeType")]
        public string ApplicationRuntimeType{ get; set; }

        /// <summary>
        /// 需要绑定的数据集ID
        /// </summary>
        [JsonProperty("ProgramId")]
        public string ProgramId{ get; set; }

        /// <summary>
        /// 服务配置信息列表
        /// </summary>
        [JsonProperty("ServiceConfigList")]
        public ServiceConfig[] ServiceConfigList{ get; set; }

        /// <summary>
        /// 忽略创建镜像仓库
        /// </summary>
        [JsonProperty("IgnoreCreateImageRepository")]
        public bool? IgnoreCreateImageRepository{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("ProgramIdList")]
        public string[] ProgramIdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "ApplicationType", this.ApplicationType);
            this.SetParamSimple(map, prefix + "MicroserviceType", this.MicroserviceType);
            this.SetParamSimple(map, prefix + "ApplicationDesc", this.ApplicationDesc);
            this.SetParamSimple(map, prefix + "ApplicationLogConfig", this.ApplicationLogConfig);
            this.SetParamSimple(map, prefix + "ApplicationResourceType", this.ApplicationResourceType);
            this.SetParamSimple(map, prefix + "ApplicationRuntimeType", this.ApplicationRuntimeType);
            this.SetParamSimple(map, prefix + "ProgramId", this.ProgramId);
            this.SetParamArrayObj(map, prefix + "ServiceConfigList.", this.ServiceConfigList);
            this.SetParamSimple(map, prefix + "IgnoreCreateImageRepository", this.IgnoreCreateImageRepository);
            this.SetParamArraySimple(map, prefix + "ProgramIdList.", this.ProgramIdList);
        }
    }
}

