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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServiceInfo : AbstractModel
    {
        
        /// <summary>
        /// 服务id
        /// </summary>
        [JsonProperty("ServiceID")]
        public string ServiceID{ get; set; }

        /// <summary>
        /// 主机id
        /// </summary>
        [JsonProperty("HostID")]
        public string HostID{ get; set; }

        /// <summary>
        /// 主机ip
        /// </summary>
        [JsonProperty("HostIP")]
        public string HostIP{ get; set; }

        /// <summary>
        /// 容器名
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// 服务名 例如nginx/redis
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        [JsonProperty("RunAs")]
        public string RunAs{ get; set; }

        /// <summary>
        /// 监听端口
        /// </summary>
        [JsonProperty("Listen")]
        public string[] Listen{ get; set; }

        /// <summary>
        /// 配置
        /// </summary>
        [JsonProperty("Config")]
        public string Config{ get; set; }

        /// <summary>
        /// 关联进程数
        /// </summary>
        [JsonProperty("ProcessCnt")]
        public ulong? ProcessCnt{ get; set; }

        /// <summary>
        /// 访问日志
        /// </summary>
        [JsonProperty("AccessLog")]
        public string AccessLog{ get; set; }

        /// <summary>
        /// 错误日志
        /// </summary>
        [JsonProperty("ErrorLog")]
        public string ErrorLog{ get; set; }

        /// <summary>
        /// 数据目录
        /// </summary>
        [JsonProperty("DataPath")]
        public string DataPath{ get; set; }

        /// <summary>
        /// web目录
        /// </summary>
        [JsonProperty("WebRoot")]
        public string WebRoot{ get; set; }

        /// <summary>
        /// 关联的进程id
        /// </summary>
        [JsonProperty("Pids")]
        public ulong?[] Pids{ get; set; }

        /// <summary>
        /// 服务类型 app,web,db
        /// </summary>
        [JsonProperty("MainType")]
        public string MainType{ get; set; }

        /// <summary>
        /// 执行文件
        /// </summary>
        [JsonProperty("Exe")]
        public string Exe{ get; set; }

        /// <summary>
        /// 服务命令行参数
        /// </summary>
        [JsonProperty("Parameter")]
        public string Parameter{ get; set; }

        /// <summary>
        /// 容器id
        /// </summary>
        [JsonProperty("ContainerId")]
        public string ContainerId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceID", this.ServiceID);
            this.SetParamSimple(map, prefix + "HostID", this.HostID);
            this.SetParamSimple(map, prefix + "HostIP", this.HostIP);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "RunAs", this.RunAs);
            this.SetParamArraySimple(map, prefix + "Listen.", this.Listen);
            this.SetParamSimple(map, prefix + "Config", this.Config);
            this.SetParamSimple(map, prefix + "ProcessCnt", this.ProcessCnt);
            this.SetParamSimple(map, prefix + "AccessLog", this.AccessLog);
            this.SetParamSimple(map, prefix + "ErrorLog", this.ErrorLog);
            this.SetParamSimple(map, prefix + "DataPath", this.DataPath);
            this.SetParamSimple(map, prefix + "WebRoot", this.WebRoot);
            this.SetParamArraySimple(map, prefix + "Pids.", this.Pids);
            this.SetParamSimple(map, prefix + "MainType", this.MainType);
            this.SetParamSimple(map, prefix + "Exe", this.Exe);
            this.SetParamSimple(map, prefix + "Parameter", this.Parameter);
            this.SetParamSimple(map, prefix + "ContainerId", this.ContainerId);
        }
    }
}

