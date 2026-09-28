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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateFunctionConfigurationRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>环境ID</p>
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// <p>要修改的函数名称</p>
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// <p>函数描述。最大支持 1000 个英文字母、数字、空格、逗号和英文句号，支持中文</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>函数运行时内存大小，默认为 128 M，可选范围64M、128 M-3072 M，以 128MB 为阶梯。</p>
        /// </summary>
        [JsonProperty("MemorySize")]
        public long? MemorySize{ get; set; }

        /// <summary>
        /// <p>函数最长执行时间，单位为秒，可选值范围 1-900 秒，默认为 3 秒</p>
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// <p>函数的环境变量</p>
        /// </summary>
        [JsonProperty("Environment")]
        public FunctionEnvironment Environment{ get; set; }

        /// <summary>
        /// <p>函数的私有网络配置</p>
        /// </summary>
        [JsonProperty("VpcConfig")]
        public FunctionVpcConfig VpcConfig{ get; set; }

        /// <summary>
        /// <p>公网访问配置</p>
        /// </summary>
        [JsonProperty("PublicNetConfig")]
        public FunctionPublicNetConfig PublicNetConfig{ get; set; }

        /// <summary>
        /// <p>函数运行环境，创建时指定，目前不支持修改。</p>
        /// </summary>
        [JsonProperty("Runtime")]
        public string Runtime{ get; set; }

        /// <summary>
        /// <p>函数绑定的角色</p>
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// <p>在线依赖安装，TRUE 表示安装，仅支持 Node.js 函数。 </p><p>默认值：FALSE</p>
        /// </summary>
        [JsonProperty("InstallDependency")]
        public string InstallDependency{ get; set; }

        /// <summary>
        /// <p>日志投递到的cls Topic ID</p>
        /// </summary>
        [JsonProperty("ClsTopicId")]
        public string ClsTopicId{ get; set; }

        /// <summary>
        /// <p>日志投递到的cls日志集ID</p>
        /// </summary>
        [JsonProperty("ClsLogsetId")]
        public string ClsLogsetId{ get; set; }

        /// <summary>
        /// <p>在更新时是否同步发布新版本</p><p>默认值：FALSE</p>
        /// </summary>
        [JsonProperty("Publish")]
        public string Publish{ get; set; }

        /// <summary>
        /// <p>是否开启L5访问能力，TRUE 为开启，FALSE为关闭</p>
        /// </summary>
        [JsonProperty("L5Enable")]
        public string L5Enable{ get; set; }

        /// <summary>
        /// <p>函数要关联的层版本列表，层的版本会按照在列表中顺序依次覆盖。</p>
        /// </summary>
        [JsonProperty("Layers")]
        public FunctionLayer[] Layers{ get; set; }

        /// <summary>
        /// <p>函数初始化执行超时时间</p>
        /// </summary>
        [JsonProperty("InitTimeout")]
        public long? InitTimeout{ get; set; }

        /// <summary>
        /// <p>是否开启Dns缓存能力。只支持EVENT函数。</p><p>默认值：FALSE</p>
        /// </summary>
        [JsonProperty("DnsCache")]
        public string DnsCache{ get; set; }

        /// <summary>
        /// <p>忽略系统日志上报</p>
        /// </summary>
        [JsonProperty("IgnoreSysLog")]
        public string IgnoreSysLog{ get; set; }

        /// <summary>
        /// <p>固定IP配置</p>
        /// </summary>
        [JsonProperty("EipConfig")]
        public FunctionEipConfigFixed[] EipConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "MemorySize", this.MemorySize);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamObj(map, prefix + "Environment.", this.Environment);
            this.SetParamObj(map, prefix + "VpcConfig.", this.VpcConfig);
            this.SetParamObj(map, prefix + "PublicNetConfig.", this.PublicNetConfig);
            this.SetParamSimple(map, prefix + "Runtime", this.Runtime);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "InstallDependency", this.InstallDependency);
            this.SetParamSimple(map, prefix + "ClsTopicId", this.ClsTopicId);
            this.SetParamSimple(map, prefix + "ClsLogsetId", this.ClsLogsetId);
            this.SetParamSimple(map, prefix + "Publish", this.Publish);
            this.SetParamSimple(map, prefix + "L5Enable", this.L5Enable);
            this.SetParamArrayObj(map, prefix + "Layers.", this.Layers);
            this.SetParamSimple(map, prefix + "InitTimeout", this.InitTimeout);
            this.SetParamSimple(map, prefix + "DnsCache", this.DnsCache);
            this.SetParamSimple(map, prefix + "IgnoreSysLog", this.IgnoreSysLog);
            this.SetParamArrayObj(map, prefix + "EipConfig.", this.EipConfig);
        }
    }
}

