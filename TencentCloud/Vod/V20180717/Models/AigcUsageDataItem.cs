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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AigcUsageDataItem : AbstractModel
    {
        
        /// <summary>
        /// AIGC规格。
        /// 取值有：
        /// <li>Qwen2.0</li>
        /// <li>Hunyuan3.0_1K</li>
        /// <li>Hunyuan3.0_2K</li>
        /// <li>Hunyuan3.0_4K</li>
        /// <li>Mingmou1.0_1K</li>
        /// <li>Mingmou1.0_2K</li>
        /// <li>Mingmou1.0_4K</li>
        /// <li>ViduQ2_T2i_1080P</li>
        /// <li>ViduQ2_T2i_2K</li>
        /// <li>ViduQ2_T2i_4K</li>
        /// <li>ViduQ2_I2i_1080P</li>
        /// <li>ViduQ2_I2i_2K</li>
        /// <li>ViduQ2_I2i_4K</li>
        /// <li>ViduQ2_Refer2i_1080P</li>
        /// <li>ViduQ2_Refer2i_2K</li>
        /// <li>ViduQ2_Refer2i_4K</li>
        /// <li>Kling2.1_T2i_1K2K</li>
        /// <li>Kling2.1_T2i_4K</li>
        /// <li>Kling2.1_Refer2i_1K</li>
        /// <li>Kling2.1_Refer2i_2K</li>
        /// <li>Kling2.1_Refer2i_4K</li>
        /// <li>Veo3.1Standard</li>
        /// <li>Veo3.1Fast</li>
        /// <li>Kling2.0&2.1std_720P</li>
        /// <li>Kling2.0&2.1pro_1080P</li>
        /// <li>Kling2.5pro_720P</li>
        /// <li>Kling2.5pro_1080P</li>
        /// <li>KlingO1_720P</li>
        /// <li>KlingO1_1080P</li>
        /// <li>KlingO1_NoVideo_720P</li>
        /// <li>KlingO1_NoVideo_1080P</li>
        /// <li>Kling2.6</li>
        /// <li>Kling2.6Sound</li>
        /// <li>Kling2.6MotionControl_720P</li>
        /// <li>Kling2.6MotionControl_1080P</li>
        /// <li>Kling_Avatar_I2v_720P</li>
        /// <li>Kling_Avatar_I2v_1080P</li>
        /// <li>Kling_Identifyface</li>
        /// <li>Hailuo02&2.3_768P</li>
        /// <li>Hailuo02&2.3_1080P</li>
        /// <li>Hailuo2.3fast_768P</li>
        /// <li>Hailuo2.3fast_1080P</li>
        /// <li>ViduQ2_720P</li>
        /// <li>ViduQ2_720P_OffPeak</li>
        /// <li>ViduQ2_1080P</li>
        /// <li>ViduQ2_1080P_OffPeak</li>
        /// <li>ViduQ2pro_720P</li>
        /// <li>ViduQ2pro_720P_OffPeak</li>
        /// <li>ViduQ2pro_1080P</li>
        /// <li>ViduQ2pro_1080P_OffPeak</li>
        /// <li>ViduQ2turbo_720P</li>
        /// <li>ViduQ2turbo_720P_OffPeak</li>
        /// <li>ViduQ2turbo_1080P</li>
        /// <li>ViduQ2turbo_1080P_OffPeak</li>
        /// <li>ViduQ3pro_720P</li>
        /// <li>ViduQ3pro_720P_OffPeak</li>
        /// <li>ViduQ3pro_1080P</li>
        /// <li>ViduQ3pro_1080P_OffPeak</li>
        /// <li>Vidu_TemplateEffect</li>
        /// <li>Hunyuan1.5_720P</li>
        /// <li>Hunyuan1.5_1080P</li>
        /// <li>Mingmou1.0_720P</li>
        /// <li>Mingmou1.0_1080P</li>
        /// <li>ImageProductImage</li>
        /// <li>ImageChangeClothes</li>
        /// <li>VideoProductShowcase</li>
        /// <li>ImageOutPainting</li>
        /// <li>unknown</li>
        /// </summary>
        [JsonProperty("Specification")]
        public string Specification{ get; set; }

        /// <summary>
        /// 用量数据。
        /// </summary>
        [JsonProperty("DataSet")]
        public TaskStatDataItem[] DataSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Specification", this.Specification);
            this.SetParamArrayObj(map, prefix + "DataSet.", this.DataSet);
        }
    }
}

