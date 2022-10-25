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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateApplicationRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用名
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 是否使用默认镜像服务 1-是，0-否
        /// </summary>
        [JsonProperty("UseDefaultImageService")]
        public long? UseDefaultImageService{ get; set; }

        /// <summary>
        /// 如果是绑定仓库，绑定的仓库类型，0-个人版，1-企业版
        /// </summary>
        [JsonProperty("RepoType")]
        public long? RepoType{ get; set; }

        /// <summary>
        /// 企业版镜像服务的实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 绑定镜像服务器地址
        /// </summary>
        [JsonProperty("RepoServer")]
        public string RepoServer{ get; set; }

        /// <summary>
        /// 绑定镜像仓库名
        /// </summary>
        [JsonProperty("RepoName")]
        public string RepoName{ get; set; }

        /// <summary>
        /// 来源渠道
        /// </summary>
        [JsonProperty("SourceChannel")]
        public long? SourceChannel{ get; set; }

        /// <summary>
        /// 应用所在子网
        /// </summary>
        [JsonProperty("SubnetList")]
        public string[] SubnetList{ get; set; }

        /// <summary>
        /// 编程语言 
        /// - JAVA
        /// - OTHER
        /// </summary>
        [JsonProperty("CodingLanguage")]
        public string CodingLanguage{ get; set; }

        /// <summary>
        /// 部署方式 
        /// - IMAGE
        /// - JAR
        /// - WAR
        /// </summary>
        [JsonProperty("DeployMode")]
        public string DeployMode{ get; set; }

        /// <summary>
        /// 是否开启 Java 应用的 APM 自动上报功能，1 表示启用；0 表示关闭
        /// </summary>
        [JsonProperty("EnableTracing")]
        public long? EnableTracing{ get; set; }

        /// <summary>
        /// 使用默认镜像服务额外参数
        /// </summary>
        [JsonProperty("UseDefaultImageServiceParameters")]
        public UseDefaultRepoParameters UseDefaultImageServiceParameters{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "UseDefaultImageService", this.UseDefaultImageService);
            this.SetParamSimple(map, prefix + "RepoType", this.RepoType);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "RepoServer", this.RepoServer);
            this.SetParamSimple(map, prefix + "RepoName", this.RepoName);
            this.SetParamSimple(map, prefix + "SourceChannel", this.SourceChannel);
            this.SetParamArraySimple(map, prefix + "SubnetList.", this.SubnetList);
            this.SetParamSimple(map, prefix + "CodingLanguage", this.CodingLanguage);
            this.SetParamSimple(map, prefix + "DeployMode", this.DeployMode);
            this.SetParamSimple(map, prefix + "EnableTracing", this.EnableTracing);
            this.SetParamObj(map, prefix + "UseDefaultImageServiceParameters.", this.UseDefaultImageServiceParameters);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

