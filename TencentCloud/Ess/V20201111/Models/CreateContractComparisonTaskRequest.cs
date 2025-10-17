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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateContractComparisonTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行合同审查任务的员工信息。
        /// 注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 原版文件ID，对比基准的旧版本文件唯一标识，通过<a href="https://qian.tencent.com/developers/companyApis/templatesAndFiles/UploadFiles" target="_blank">UploadFiles</a>接口获取文件资源ID。
        /// </summary>
        [JsonProperty("OriginFileResourceId")]
        public string OriginFileResourceId{ get; set; }

        /// <summary>
        /// 新版文件ID，与旧版进行对比的新版本文件唯一标识，通过<a href="https://qian.tencent.com/developers/companyApis/templatesAndFiles/UploadFiles" target="_blank">UploadFiles</a>接口获取文件资源ID。
        /// </summary>
        [JsonProperty("DiffFileResourceId")]
        public string DiffFileResourceId{ get; set; }

        /// <summary>
        /// 对比任务备注，长度不能超过50个字符。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 调用方自定义的个性化字段(可自定义此名称)，并以base64方式编码，支持的最大数据大小为 1024长度。
        /// 
        /// 在合同状态变更的回调信息等场景中，该字段的信息将原封不动地透传给贵方。回调的相关说明可参考开发者中心的[回调通知](https://qian.tencent.com/developers/company/callback_types_v2)模块。
        /// </summary>
        [JsonProperty("UserData")]
        public string UserData{ get; set; }

        /// <summary>
        /// 标签列表，用户自定义的键值对（Key-Value），可绑定到资源上，用于资源的分类、管理和访问控制。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "OriginFileResourceId", this.OriginFileResourceId);
            this.SetParamSimple(map, prefix + "DiffFileResourceId", this.DiffFileResourceId);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "UserData", this.UserData);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

