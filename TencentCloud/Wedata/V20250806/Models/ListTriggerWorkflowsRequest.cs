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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListTriggerWorkflowsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>项目ID</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// <p>请求的数据页数。默认值为1，取值大于等于1</p>
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// <p>每页显示的数据条数。默认值为10 ，最小值为10，最大值为200</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// <p>搜索关键词</p>
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// <p>工作流所属文件夹</p>
        /// </summary>
        [JsonProperty("ParentFolderPath")]
        public string ParentFolderPath{ get; set; }

        /// <summary>
        /// <p>bundleId项</p>
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId{ get; set; }

        /// <summary>
        /// <p>负责人ID</p>
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// <p>创建人ID</p>
        /// </summary>
        [JsonProperty("CreateUserUin")]
        public string CreateUserUin{ get; set; }

        /// <summary>
        /// <p>运行账号ID</p>
        /// </summary>
        [JsonProperty("ExecuteUserUin")]
        public string ExecuteUserUin{ get; set; }

        /// <summary>
        /// <p>修改时间区间 yyyy-MM-dd HH:mm:ss，需要在数组填入两个时间</p>
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string[] ModifyTime{ get; set; }

        /// <summary>
        /// <p>创建时间区间 yyyy-MM-dd HH:mm:ss，需要在数组填入两个时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string[] CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamSimple(map, prefix + "ParentFolderPath", this.ParentFolderPath);
            this.SetParamSimple(map, prefix + "BundleId", this.BundleId);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "CreateUserUin", this.CreateUserUin);
            this.SetParamSimple(map, prefix + "ExecuteUserUin", this.ExecuteUserUin);
            this.SetParamArraySimple(map, prefix + "ModifyTime.", this.ModifyTime);
            this.SetParamArraySimple(map, prefix + "CreateTime.", this.CreateTime);
        }
    }
}

