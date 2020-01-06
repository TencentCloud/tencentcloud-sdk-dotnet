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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePullStreamConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 源Url。目前可支持直播流及点播文件。
        /// </summary>
        [JsonProperty("FromUrl")]
        public string FromUrl{ get; set; }

        /// <summary>
        /// 目的Url，目前限制该目标地址为腾讯域名。
        /// </summary>
        [JsonProperty("ToUrl")]
        public string ToUrl{ get; set; }

        /// <summary>
        /// 选择完成转拉推的服务所在区域:
        /// 1-深圳，
        /// 2-上海，
        /// 3-天津，
        /// 4-中国香港。
        /// </summary>
        [JsonProperty("AreaId")]
        public long? AreaId{ get; set; }

        /// <summary>
        /// 选择完成转拉推服务使用的运营商网络：
        /// 1-电信，
        /// 2-移动，
        /// 3-联通，
        /// 4-其他。
        /// 注：AreaId为4的时候,IspId只能为其他。
        /// </summary>
        [JsonProperty("IspId")]
        public long? IspId{ get; set; }

        /// <summary>
        /// 开始时间。
        /// 使用UTC格式时间，
        /// 例如：2019-01-08T10:00:00Z。
        /// 注意：北京时间值为 UTC 时间值 + 8 小时，格式按照 ISO 8601 标准表示，详见 [ISO 日期格式说明](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间，注意：
        /// 1. 结束时间必须大于开始时间；
        /// 2. 结束时间和开始时间必须大于当前时间；
        /// 3. 结束时间 和 开始时间 间隔必须小于七天。
        /// 使用UTC格式时间，
        /// 例如：2019-01-08T10:00:00Z。
        /// 注意：北京时间值为 UTC 时间值 + 8 小时，格式按照 ISO 8601 标准表示，详见 [ISO 日期格式说明](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FromUrl", this.FromUrl);
            this.SetParamSimple(map, prefix + "ToUrl", this.ToUrl);
            this.SetParamSimple(map, prefix + "AreaId", this.AreaId);
            this.SetParamSimple(map, prefix + "IspId", this.IspId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

