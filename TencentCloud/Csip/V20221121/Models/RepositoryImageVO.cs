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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RepositoryImageVO : AbstractModel
    {
        
        /// <summary>
        /// 用户appid
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 用户uin
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// 镜像id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 镜像名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 镜像创建时间
        /// </summary>
        [JsonProperty("InstanceCreateTime")]
        public string InstanceCreateTime{ get; set; }

        /// <summary>
        /// 镜像大小带单位
        /// </summary>
        [JsonProperty("InstanceSize")]
        public string InstanceSize{ get; set; }

        /// <summary>
        /// 构建次数
        /// </summary>
        [JsonProperty("BuildCount")]
        public long? BuildCount{ get; set; }

        /// <summary>
        /// 镜像类型
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 授权状态
        /// </summary>
        [JsonProperty("AuthStatus")]
        public long? AuthStatus{ get; set; }

        /// <summary>
        /// 镜像版本
        /// </summary>
        [JsonProperty("InstanceVersion")]
        public string InstanceVersion{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 仓库地址
        /// </summary>
        [JsonProperty("RepositoryUrl")]
        public string RepositoryUrl{ get; set; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        [JsonProperty("RepositoryName")]
        public string RepositoryName{ get; set; }

        /// <summary>
        /// 是否核心
        /// </summary>
        [JsonProperty("IsCore")]
        public ulong? IsCore{ get; set; }

        /// <summary>
        /// 漏洞风险
        /// </summary>
        [JsonProperty("VulRisk")]
        public long? VulRisk{ get; set; }

        /// <summary>
        /// 检查任务
        /// </summary>
        [JsonProperty("CheckCount")]
        public long? CheckCount{ get; set; }

        /// <summary>
        /// 体检时间
        /// </summary>
        [JsonProperty("CheckTime")]
        public string CheckTime{ get; set; }

        /// <summary>
        /// 是否新资产 1新
        /// </summary>
        [JsonProperty("IsNewAsset")]
        public ulong? IsNewAsset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceCreateTime", this.InstanceCreateTime);
            this.SetParamSimple(map, prefix + "InstanceSize", this.InstanceSize);
            this.SetParamSimple(map, prefix + "BuildCount", this.BuildCount);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "AuthStatus", this.AuthStatus);
            this.SetParamSimple(map, prefix + "InstanceVersion", this.InstanceVersion);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "RepositoryUrl", this.RepositoryUrl);
            this.SetParamSimple(map, prefix + "RepositoryName", this.RepositoryName);
            this.SetParamSimple(map, prefix + "IsCore", this.IsCore);
            this.SetParamSimple(map, prefix + "VulRisk", this.VulRisk);
            this.SetParamSimple(map, prefix + "CheckCount", this.CheckCount);
            this.SetParamSimple(map, prefix + "CheckTime", this.CheckTime);
            this.SetParamSimple(map, prefix + "IsNewAsset", this.IsNewAsset);
        }
    }
}

