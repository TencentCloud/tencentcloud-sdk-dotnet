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

namespace TencentCloud.Rce.V20201103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InputDescribeNameListFront : AbstractModel
    {
        
        /// <summary>
        /// 当前页数
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// 每页显示条数
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 名单类型 [1 黑名单 2 白名单]
        /// </summary>
        [JsonProperty("ListType")]
        public long? ListType{ get; set; }

        /// <summary>
        /// 数据类型[1 手机号 2 qqOpenId 3 wechatOpenId 4 ip 6 idfa 7 imei]
        /// </summary>
        [JsonProperty("DataType")]
        public long? DataType{ get; set; }

        /// <summary>
        /// 关键字，按照名单名称搜索
        /// </summary>
        [JsonProperty("KeyWord")]
        public string KeyWord{ get; set; }

        /// <summary>
        /// 记录状态[1 启用 2 停用]
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "ListType", this.ListType);
            this.SetParamSimple(map, prefix + "DataType", this.DataType);
            this.SetParamSimple(map, prefix + "KeyWord", this.KeyWord);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

