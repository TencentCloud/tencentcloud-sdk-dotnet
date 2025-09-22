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

    public class ListResourceFilesRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 数据页数，大于等于1。默认1
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// 每页显示的数据条数，最小为10条，最大为200 条。默认10
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 资源文件名称(模糊搜索关键词)
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// 资源文件所属文件夹路径(如/a/b/c，查询c文件夹下的资源文件)
        /// </summary>
        [JsonProperty("ParentFolderPath")]
        public string ParentFolderPath{ get; set; }

        /// <summary>
        /// 创建人ID, 可通过DescribeCurrentUserInfo接口获取
        /// </summary>
        [JsonProperty("CreateUserUin")]
        public string CreateUserUin{ get; set; }

        /// <summary>
        /// 更新时间范围,开始时间, 格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("ModifyTimeStart")]
        public string ModifyTimeStart{ get; set; }

        /// <summary>
        /// 更新时间范围,结束时间, 格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("ModifyTimeEnd")]
        public string ModifyTimeEnd{ get; set; }

        /// <summary>
        /// 创建时间范围,开始时间, 格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("CreateTimeStart")]
        public string CreateTimeStart{ get; set; }

        /// <summary>
        /// 创建时间范围,结束时间, 格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("CreateTimeEnd")]
        public string CreateTimeEnd{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "ParentFolderPath", this.ParentFolderPath);
            this.SetParamSimple(map, prefix + "CreateUserUin", this.CreateUserUin);
            this.SetParamSimple(map, prefix + "ModifyTimeStart", this.ModifyTimeStart);
            this.SetParamSimple(map, prefix + "ModifyTimeEnd", this.ModifyTimeEnd);
            this.SetParamSimple(map, prefix + "CreateTimeStart", this.CreateTimeStart);
            this.SetParamSimple(map, prefix + "CreateTimeEnd", this.CreateTimeEnd);
        }
    }
}

