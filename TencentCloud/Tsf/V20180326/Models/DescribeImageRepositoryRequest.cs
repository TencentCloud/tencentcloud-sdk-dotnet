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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeImageRepositoryRequest : AbstractModel
    {
        
        /// <summary>
        /// 仓库名，搜索关键字,不带命名空间的
        /// </summary>
        [JsonProperty("SearchWord")]
        public string SearchWord{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。关于Offset详见[API简介](https://cloud.tencent.com/document/api/213/568#.E8.BE.93.E5.85.A5.E5.8F.82.E6.95.B0.E4.B8.8E.E8.BF.94.E5.9B.9E.E5.8F.82.E6.95.B0.E9.87.8A.E4.B9.89)
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 数量限制，默认为20，最大值为100。关于Limit详见[API简介](https://cloud.tencent.com/document/api/213/568#.E8.BE.93.E5.85.A5.E5.8F.82.E6.95.B0.E4.B8.8E.E8.BF.94.E5.9B.9E.E5.8F.82.E6.95.B0.E9.87.8A.E4.B9.89)
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 企业: tcr ；个人: personal或者不填
        /// </summary>
        [JsonProperty("RepoType")]
        public string RepoType{ get; set; }

        /// <summary>
        /// 应用ID，可通过调用[DescribeApplications](https://cloud.tencent.com/document/api/649/36090)查询已创建的应用列表或登录控制台进行查看；也可以调用[CreateApplication](https://cloud.tencent.com/document/api/649/36094)创建新的应用。
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// TcrRepoInfo值
        /// </summary>
        [JsonProperty("TcrRepoInfo")]
        public TcrRepoInfo TcrRepoInfo{ get; set; }

        /// <summary>
        /// 镜像仓库名称
        /// </summary>
        [JsonProperty("RepoName")]
        public string RepoName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SearchWord", this.SearchWord);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "RepoType", this.RepoType);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamObj(map, prefix + "TcrRepoInfo.", this.TcrRepoInfo);
            this.SetParamSimple(map, prefix + "RepoName", this.RepoName);
        }
    }
}

