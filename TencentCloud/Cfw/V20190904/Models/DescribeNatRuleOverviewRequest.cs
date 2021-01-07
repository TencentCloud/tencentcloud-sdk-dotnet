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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeNatRuleOverviewRequest : AbstractModel
    {
        
        /// <summary>
        /// 方向，0：出站，1：入站 默认值：0
        /// </summary>
        [JsonProperty("Direction")]
        public ulong? Direction{ get; set; }

        /// <summary>
        /// NAT地域  这个是必填项，填入相关的英文，'ap-beijing-fsi': '北京金融',
        ///         'ap-beijing': '北京',
        ///         'ap-changsha-ec': '长沙EC',
        ///         'ap-chengdu': '成都',
        ///         'ap-chongqing': '重庆',
        ///         'ap-fuzhou-ec': '福州EC',
        ///         'ap-guangzhou-open': '广州Open',
        ///         'ap-guangzhou': '广州',
        ///         'ap-hangzhou-ec': '杭州EC',
        ///         'ap-jinan-ec': '济南EC',
        ///         'ap-nanjing': '南京',
        ///         'ap-shanghai-fsi': '上海金融',
        ///         'ap-shanghai': '上海',
        ///         'ap-shenzhen-fsi': '深圳金融',
        ///         'ap-shenzhen': '深圳',
        ///         'ap-wuhan-ec': '武汉EC'
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "Area", this.Area);
        }
    }
}

