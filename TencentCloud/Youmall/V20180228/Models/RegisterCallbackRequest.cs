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

namespace TencentCloud.Youmall.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RegisterCallbackRequest : AbstractModel
    {
        
        /// <summary>
        /// 集团id，通过"指定身份标识获取客户门店列表"接口获取
        /// </summary>
        [JsonProperty("CompanyId")]
        public string CompanyId{ get; set; }

        /// <summary>
        /// 通知回调地址，完整url，示例（http://youmall.tencentcloudapi.com/）
        /// </summary>
        [JsonProperty("BackUrl")]
        public string BackUrl{ get; set; }

        /// <summary>
        /// 请求时间戳
        /// </summary>
        [JsonProperty("Time")]
        public ulong? Time{ get; set; }

        /// <summary>
        /// 是否需要顾客图片，1-需要图片，其它-不需要图片
        /// </summary>
        [JsonProperty("NeedFacePic")]
        public ulong? NeedFacePic{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompanyId", this.CompanyId);
            this.SetParamSimple(map, prefix + "BackUrl", this.BackUrl);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "NeedFacePic", this.NeedFacePic);
        }
    }
}

