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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RoleInfo : AbstractModel
    {
        
        /// <summary>
        /// IP
        /// </summary>
        [JsonProperty("IP")]
        public string IP{ get; set; }

        /// <summary>
        /// HostIP
        /// </summary>
        [JsonProperty("HostIP")]
        public string HostIP{ get; set; }

        /// <summary>
        /// 原始IP
        /// </summary>
        [JsonProperty("OriginIP")]
        public string OriginIP{ get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// 资产ID
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        [JsonProperty("Country")]
        public string Country{ get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [JsonProperty("Latitude")]
        public string Latitude{ get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonProperty("Longitude")]
        public string Longitude{ get; set; }

        /// <summary>
        /// 信息
        /// </summary>
        [JsonProperty("Info")]
        public string Info{ get; set; }

        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        [JsonProperty("Account")]
        public string Account{ get; set; }

        /// <summary>
        /// 家族团伙
        /// </summary>
        [JsonProperty("Family")]
        public string Family{ get; set; }

        /// <summary>
        /// 病毒名
        /// </summary>
        [JsonProperty("VirusName")]
        public string VirusName{ get; set; }

        /// <summary>
        /// MD5值
        /// </summary>
        [JsonProperty("MD5")]
        public string MD5{ get; set; }

        /// <summary>
        /// 恶意进程文件名
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 1:主机资产 2:域名资产 3:网络资产
        /// </summary>
        [JsonProperty("AssetType")]
        public long? AssetType{ get; set; }

        /// <summary>
        /// 来源日志分析的信息字段
        /// </summary>
        [JsonProperty("FromLogAnalysisData")]
        public KeyValue[] FromLogAnalysisData{ get; set; }

        /// <summary>
        /// 容器名
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// 容器ID
        /// </summary>
        [JsonProperty("ContainerID")]
        public string ContainerID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IP", this.IP);
            this.SetParamSimple(map, prefix + "HostIP", this.HostIP);
            this.SetParamSimple(map, prefix + "OriginIP", this.OriginIP);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "Country", this.Country);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "Latitude", this.Latitude);
            this.SetParamSimple(map, prefix + "Longitude", this.Longitude);
            this.SetParamSimple(map, prefix + "Info", this.Info);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Account", this.Account);
            this.SetParamSimple(map, prefix + "Family", this.Family);
            this.SetParamSimple(map, prefix + "VirusName", this.VirusName);
            this.SetParamSimple(map, prefix + "MD5", this.MD5);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamArrayObj(map, prefix + "FromLogAnalysisData.", this.FromLogAnalysisData);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamSimple(map, prefix + "ContainerID", this.ContainerID);
        }
    }
}

