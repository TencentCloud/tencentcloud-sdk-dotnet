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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloudBaseRunForGatewayConf : AbstractModel
    {
        
        /// <summary>
        /// 是否缩容到0
        /// </summary>
        [JsonProperty("IsZero")]
        public bool? IsZero{ get; set; }

        /// <summary>
        /// 按百分比灰度的权重
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }

        /// <summary>
        /// 按请求/header参数的灰度Key
        /// </summary>
        [JsonProperty("GrayKey")]
        public string GrayKey{ get; set; }

        /// <summary>
        /// 按请求/header参数的灰度Value
        /// </summary>
        [JsonProperty("GrayValue")]
        public string GrayValue{ get; set; }

        /// <summary>
        /// 是否为默认版本(按请求/header参数)
        /// </summary>
        [JsonProperty("IsDefault")]
        public bool? IsDefault{ get; set; }

        /// <summary>
        /// 访问权限，对应二进制分多段，vpc内网｜公网｜oa
        /// </summary>
        [JsonProperty("AccessType")]
        public long? AccessType{ get; set; }

        /// <summary>
        /// 访问的URL（域名＋路径）列表
        /// </summary>
        [JsonProperty("URLs")]
        public string[] URLs{ get; set; }

        /// <summary>
        /// 环境ID
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [JsonProperty("ServerName")]
        public string ServerName{ get; set; }

        /// <summary>
        /// 版本名称
        /// </summary>
        [JsonProperty("VersionName")]
        public string VersionName{ get; set; }

        /// <summary>
        /// 灰度类型：FLOW(权重), URL_PARAMS/HEAD_PARAMS
        /// </summary>
        [JsonProperty("GrayType")]
        public string GrayType{ get; set; }

        /// <summary>
        /// CLB的IP:Port
        /// </summary>
        [JsonProperty("LbAddr")]
        public string LbAddr{ get; set; }

        /// <summary>
        /// 0:http访问服务配置信息, 1: 服务域名
        /// </summary>
        [JsonProperty("ConfigType")]
        public long? ConfigType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsZero", this.IsZero);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "GrayKey", this.GrayKey);
            this.SetParamSimple(map, prefix + "GrayValue", this.GrayValue);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamArraySimple(map, prefix + "URLs.", this.URLs);
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "ServerName", this.ServerName);
            this.SetParamSimple(map, prefix + "VersionName", this.VersionName);
            this.SetParamSimple(map, prefix + "GrayType", this.GrayType);
            this.SetParamSimple(map, prefix + "LbAddr", this.LbAddr);
            this.SetParamSimple(map, prefix + "ConfigType", this.ConfigType);
        }
    }
}

