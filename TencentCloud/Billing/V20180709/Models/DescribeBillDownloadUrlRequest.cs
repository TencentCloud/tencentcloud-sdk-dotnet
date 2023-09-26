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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBillDownloadUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// 账单类型，枚举值
        /// billOverview=L0-PDF账单
        /// billSummary=L1-汇总账单	
        /// billResource=L2-资源账单	
        /// billDetail=L3-明细账单	
        /// billPack=账单包
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// 账单月份
        /// 支持的最早开始月份为2021-01
        /// L0-PDF&账单包不支持当月下载，当月账单请在次月1号19:00出账后下载
        /// </summary>
        [JsonProperty("Month")]
        public string Month{ get; set; }

        /// <summary>
        /// 下载的账号 ID列表，默认查询本账号账单，如集团管理账号需下载成员账号自付的账单，该字段需入参成员账号UIN
        /// </summary>
        [JsonProperty("ChildUin")]
        public string[] ChildUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "Month", this.Month);
            this.SetParamArraySimple(map, prefix + "ChildUin.", this.ChildUin);
        }
    }
}

