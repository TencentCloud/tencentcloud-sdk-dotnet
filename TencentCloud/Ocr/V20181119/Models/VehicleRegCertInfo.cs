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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VehicleRegCertInfo : AbstractModel
    {
        
        /// <summary>
        /// 识别出的字段名称(关键字)，支持以下字段：
        /// 【注册登记页】
        /// 车辆型号、车辆识别代号/车架号、发动机号、制造厂名称、轴距、轮胎数、总质量、外廓尺寸、轴数、车辆出厂日期、发证日期、使用性质、车辆获得方式、车辆类型、国产/进口、燃料种类、车身颜色、发动机型号、车辆品牌、编号、转向形式、
        /// 机动车所有人1、身份证明名称1、号码1、登记机关1、登记日期1
        /// 机动车所有人2、身份证明名称2、号码2、登记机关2、登记日期2
        /// 机动车所有人3、身份证明名称3、号码3、登记机关3、登记日期3
        /// 机动车所有人4、身份证明名称4、号码4、登记机关4、登记日期4
        /// 机动车所有人5、身份证明名称5、号码5、登记机关5、登记日期5
        /// 机动车所有人6、身份证明名称6、号码6、登记机关6、登记日期6
        /// 机动车所有人7、身份证明名称7、号码7、登记机关7、登记日期7
        /// 【抵押登记页】
        /// 机动车登记证书编号、身份证明名称/号码、抵押权人姓名/名称、抵押登记日期。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 识别出的字段名称对应的值，也就是字段name对应的字符串结果。
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Value", this.Value);
        }
    }
}

