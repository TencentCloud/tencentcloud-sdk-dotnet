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

namespace TencentCloud.Cms.V20190321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TextOutputRes : AbstractModel
    {
        
        /// <summary>
        /// 操作人,信安处理人企业微信ID
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// 恶意类型，广告（10001）， 政治（20001）， 色情（20002）， 社会事件（20004）， 暴力（20011）， 低俗（20012）， 违法犯罪（20006）， 欺诈（20008）， 版权（20013）， 谣言（20104）， 其他（21000）
        /// </summary>
        [JsonProperty("ResultType")]
        public long? ResultType{ get; set; }

        /// <summary>
        /// 恶意操作码，
        /// 删除（1）， 通过（2）， 先审后发（100012）
        /// </summary>
        [JsonProperty("ResultCode")]
        public long? ResultCode{ get; set; }

        /// <summary>
        /// 操作结果备注说明
        /// </summary>
        [JsonProperty("ResultMsg")]
        public string ResultMsg{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "ResultType", this.ResultType);
            this.SetParamSimple(map, prefix + "ResultCode", this.ResultCode);
            this.SetParamSimple(map, prefix + "ResultMsg", this.ResultMsg);
        }
    }
}

