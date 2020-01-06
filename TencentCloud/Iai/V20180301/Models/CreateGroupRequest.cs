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

namespace TencentCloud.Iai.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 人员库名称，[1,60]个字符，可修改，不可重复。
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 人员库 ID，不可修改，不可重复。支持英文、数字、-%@#&_，长度限制64B。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 人员库自定义描述字段，用于描述人员库中人员属性，该人员库下所有人员将拥有此描述字段。 
        /// 最多可以创建5个。 
        /// 每个自定义描述字段支持[1,30]个字符。 
        /// 在同一人员库中自定义描述字段不可重复。 
        /// 例： 设置某人员库“自定义描述字段”为["学号","工号","手机号"]， 
        /// 则该人员库下所有人员将拥有名为“学号”、“工号”、“手机号”的描述字段， 
        /// 可在对应人员描述字段中填写内容，登记该人员的学号、工号、手机号等信息。
        /// </summary>
        [JsonProperty("GroupExDescriptions")]
        public string[] GroupExDescriptions{ get; set; }

        /// <summary>
        /// 人员库信息备注，[0，40]个字符。
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }

        /// <summary>
        /// 人脸识别服务所用的算法模型版本。目前入参支持 “2.0”和“3.0“ 两个输入。
        /// 默认为"2.0"。
        /// 不同算法模型版本对应的人脸识别算法不同，新版本的整体效果会优于旧版本，建议使用“3.0”版本。
        /// </summary>
        [JsonProperty("FaceModelVersion")]
        public string FaceModelVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamArraySimple(map, prefix + "GroupExDescriptions.", this.GroupExDescriptions);
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
            this.SetParamSimple(map, prefix + "FaceModelVersion", this.FaceModelVersion);
        }
    }
}

