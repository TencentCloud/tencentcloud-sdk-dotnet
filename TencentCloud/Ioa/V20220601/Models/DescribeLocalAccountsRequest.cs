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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLocalAccountsRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询条件：过滤或排序
        /// 1、UserName，string类型，姓名
        /// 是否必填：否
        /// 过滤支持：是，支持eq、like、ilike
        /// 排序支持：否
        /// 2、UserId，string类型，账户
        /// 是否必填：否
        /// 过滤支持：是，支持eq、like、ilike
        /// 排序支持：否
        /// 3、Phone，string类型，手机号
        /// 是否必填：否
        /// 过滤支持：是，支持eq、like、ilike
        /// 排序支持：否
        /// </summary>
        [JsonProperty("Condition")]
        public Condition Condition{ get; set; }

        /// <summary>
        /// 获取账号的分组ID，不传默认获取全网根账号组
        /// </summary>
        [JsonProperty("AccountGroupId")]
        public long? AccountGroupId{ get; set; }

        /// <summary>
        /// 是否仅展示当前目录下用户 1： 递归显示 2：仅显示当前目录下用户(只支持32位)
        /// </summary>
        [JsonProperty("ShowFlag")]
        public long? ShowFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Condition.", this.Condition);
            this.SetParamSimple(map, prefix + "AccountGroupId", this.AccountGroupId);
            this.SetParamSimple(map, prefix + "ShowFlag", this.ShowFlag);
        }
    }
}

