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

namespace TencentCloud.Sms.V20190711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SendStatusStatistics : AbstractModel
    {
        
        /// <summary>
        /// 短信计费条数统计，例如提交成功量为100条，其中有20条是长短信（长度为80字）被拆分成2条，则计费条数为： ```80 * 1 + 20 * 2 = 120``` 条。
        /// </summary>
        [JsonProperty("FeeCount")]
        public ulong? FeeCount{ get; set; }

        /// <summary>
        /// 短信提交量统计。
        /// </summary>
        [JsonProperty("RequestCount")]
        public ulong? RequestCount{ get; set; }

        /// <summary>
        /// 短信提交成功量统计。
        /// </summary>
        [JsonProperty("RequestSuccessCount")]
        public ulong? RequestSuccessCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FeeCount", this.FeeCount);
            this.SetParamSimple(map, prefix + "RequestCount", this.RequestCount);
            this.SetParamSimple(map, prefix + "RequestSuccessCount", this.RequestSuccessCount);
        }
    }
}

