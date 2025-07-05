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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTriggerRequest : AbstractModel
    {
        
        /// <summary>
        /// 新建触发器绑定的函数名称
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// 新建触发器名称。如果是定时触发器，名称支持英文字母、数字、连接符和下划线，最长100个字符；如果是cos触发器，需要是对应cos存储桶适用于XML API的访问域名(例如:5401-5ff414-12345.cos.ap-shanghai.myqcloud.com);如果是其他触发器，见具体触发器绑定参数的说明
        /// </summary>
        [JsonProperty("TriggerName")]
        public string TriggerName{ get; set; }

        /// <summary>
        /// 触发器类型，目前支持 cos 、cls 、 timer、 ckafka、http类型。创建函数 URL 请使用 http 类型，参考[创建函数 URL ](https://cloud.tencent.com/document/product/583/100227#33bbbda4-9131-48a6-ac37-ac62ffe01424)。创建 cls 触发器请参考[CLS 创建投递 SCF 任务](https://cloud.tencent.com/document/product/614/61096)。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 触发器对应的参数，可见具体[触发器描述说明](https://cloud.tencent.com/document/product/583/39901)
        /// </summary>
        [JsonProperty("TriggerDesc")]
        public string TriggerDesc{ get; set; }

        /// <summary>
        /// 函数的命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 触发器所生效的版本或别名，建议填写 [$DEFAULT](https://cloud.tencent.com/document/product/583/36149#.E9.BB.98.E8.AE.A4.E5.88.AB.E5.90.8D)方便后续进行版本的灰度发布，默认为 $LATEST。
        /// </summary>
        [JsonProperty("Qualifier")]
        public string Qualifier{ get; set; }

        /// <summary>
        /// 触发器的初始是能状态 OPEN表示开启 CLOSE表示关闭
        /// </summary>
        [JsonProperty("Enable")]
        public string Enable{ get; set; }

        /// <summary>
        /// 用户自定义参数，仅支持timer触发器
        /// </summary>
        [JsonProperty("CustomArgument")]
        public string CustomArgument{ get; set; }

        /// <summary>
        /// 触发器描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamSimple(map, prefix + "TriggerName", this.TriggerName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "TriggerDesc", this.TriggerDesc);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Qualifier", this.Qualifier);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "CustomArgument", this.CustomArgument);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

