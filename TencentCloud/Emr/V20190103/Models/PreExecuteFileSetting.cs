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

    public class PreExecuteFileSetting : AbstractModel
    {
        
        /// <summary>
        /// 脚本在COS上路径
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// 执行脚本参数
        /// </summary>
        [JsonProperty("Args")]
        public string Args{ get; set; }

        /// <summary>
        /// COS的Bucket名称
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }

        /// <summary>
        /// COS的Region名称
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// COS的Domain数据
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 执行顺序
        /// </summary>
        [JsonProperty("RunOrder")]
        public long? RunOrder{ get; set; }

        /// <summary>
        /// resourceAfter 或 clusterAfter
        /// </summary>
        [JsonProperty("WhenRun")]
        public string WhenRun{ get; set; }

        /// <summary>
        /// 脚本文件名
        /// </summary>
        [JsonProperty("CosFileName")]
        public string CosFileName{ get; set; }

        /// <summary>
        /// 脚本的cos地址
        /// </summary>
        [JsonProperty("CosFileURI")]
        public string CosFileURI{ get; set; }

        /// <summary>
        /// cos的SecretId
        /// </summary>
        [JsonProperty("CosSecretId")]
        public string CosSecretId{ get; set; }

        /// <summary>
        /// Cos的SecretKey
        /// </summary>
        [JsonProperty("CosSecretKey")]
        public string CosSecretKey{ get; set; }

        /// <summary>
        /// cos的appid
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "Args", this.Args);
            this.SetParamSimple(map, prefix + "Bucket", this.Bucket);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "RunOrder", this.RunOrder);
            this.SetParamSimple(map, prefix + "WhenRun", this.WhenRun);
            this.SetParamSimple(map, prefix + "CosFileName", this.CosFileName);
            this.SetParamSimple(map, prefix + "CosFileURI", this.CosFileURI);
            this.SetParamSimple(map, prefix + "CosSecretId", this.CosSecretId);
            this.SetParamSimple(map, prefix + "CosSecretKey", this.CosSecretKey);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

