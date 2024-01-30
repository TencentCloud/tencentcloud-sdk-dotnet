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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeUserRoleListRequest : AbstractModel
    {
        
        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("PageNo")]
        public long? PageNo{ get; set; }

        /// <summary>
        /// 页数
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 全部页码
        /// </summary>
        [JsonProperty("AllPage")]
        public bool? AllPage{ get; set; }

        /// <summary>
        /// 0 企业用户 1 访客 不填表示所有用户
        /// </summary>
        [JsonProperty("UserType")]
        public string UserType{ get; set; }

        /// <summary>
        /// 模糊搜索的关键字
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 是否只获取绑定企微应用的
        /// </summary>
        [JsonProperty("IsOnlyBindAppUser")]
        public bool? IsOnlyBindAppUser{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageNo", this.PageNo);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "AllPage", this.AllPage);
            this.SetParamSimple(map, prefix + "UserType", this.UserType);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "IsOnlyBindAppUser", this.IsOnlyBindAppUser);
        }
    }
}

