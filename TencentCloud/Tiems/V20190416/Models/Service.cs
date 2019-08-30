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

namespace TencentCloud.Tiems.V20190416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Service : AbstractModel
    {
        
        /// <summary>
        /// 服务ID
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 运行集群
        /// </summary>
        [JsonProperty("Cluster")]
        public string Cluster{ get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 运行环境
        /// </summary>
        [JsonProperty("Runtime")]
        public string Runtime{ get; set; }

        /// <summary>
        /// 模型地址
        /// </summary>
        [JsonProperty("ModelUri")]
        public string ModelUri{ get; set; }

        /// <summary>
        /// 处理器配置, 单位为1/1000核
        /// </summary>
        [JsonProperty("Cpu")]
        public ulong? Cpu{ get; set; }

        /// <summary>
        /// 内存配置, 单位为1M
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// 处理器配置, 单位为1/100 tflops
        /// </summary>
        [JsonProperty("TflopUnits")]
        public ulong? TflopUnits{ get; set; }

        /// <summary>
        /// 显存配置, 单位为1M
        /// </summary>
        [JsonProperty("GpuMemory")]
        public ulong? GpuMemory{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 支持AUTO, MANUAL
        /// </summary>
        [JsonProperty("ScaleMode")]
        public string ScaleMode{ get; set; }

        /// <summary>
        /// 弹性伸缩配置
        /// </summary>
        [JsonProperty("Scaler")]
        public Scaler Scaler{ get; set; }

        /// <summary>
        /// 服务状态
        /// </summary>
        [JsonProperty("Status")]
        public ServiceStatus Status{ get; set; }

        /// <summary>
        /// 服务地址
        /// </summary>
        [JsonProperty("ServingIp")]
        public string ServingIp{ get; set; }

        /// <summary>
        /// 访问密钥
        /// </summary>
        [JsonProperty("AccessToken")]
        public string AccessToken{ get; set; }

        /// <summary>
        /// 服务配置Id
        /// </summary>
        [JsonProperty("ServiceConfigId")]
        public long? ServiceConfigId{ get; set; }

        /// <summary>
        /// 服务配置名
        /// </summary>
        [JsonProperty("ServiceConfigName")]
        public string ServiceConfigName{ get; set; }

        /// <summary>
        /// 服务运行时长
        /// </summary>
        [JsonProperty("ServeSeconds")]
        public ulong? ServeSeconds{ get; set; }

        /// <summary>
        /// 配置版本
        /// </summary>
        [JsonProperty("ServiceConfigVersion")]
        public string ServiceConfigVersion{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Cluster", this.Cluster);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Runtime", this.Runtime);
            this.SetParamSimple(map, prefix + "ModelUri", this.ModelUri);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "TflopUnits", this.TflopUnits);
            this.SetParamSimple(map, prefix + "GpuMemory", this.GpuMemory);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "ScaleMode", this.ScaleMode);
            this.SetParamObj(map, prefix + "Scaler.", this.Scaler);
            this.SetParamObj(map, prefix + "Status.", this.Status);
            this.SetParamSimple(map, prefix + "ServingIp", this.ServingIp);
            this.SetParamSimple(map, prefix + "AccessToken", this.AccessToken);
            this.SetParamSimple(map, prefix + "ServiceConfigId", this.ServiceConfigId);
            this.SetParamSimple(map, prefix + "ServiceConfigName", this.ServiceConfigName);
            this.SetParamSimple(map, prefix + "ServeSeconds", this.ServeSeconds);
            this.SetParamSimple(map, prefix + "ServiceConfigVersion", this.ServiceConfigVersion);
        }
    }
}

