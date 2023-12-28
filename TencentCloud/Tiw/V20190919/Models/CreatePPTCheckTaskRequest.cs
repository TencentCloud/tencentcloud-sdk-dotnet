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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePPTCheckTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 客户的SdkAppId
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// 经过URL编码后的PPT文件地址。URL 编码会将字符转换为可通过因特网传输的格式，例如文档地址为http://example.com/测试.pptx，经过URL编码之后为http://example.com/%E6%B5%8B%E8%AF%95.pptx。为了提高URL解析的成功率，请对URL进行编码。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 是否对不支持元素开启自动处理的功能，默认不开启。
        /// true -- 开启
        /// false -- 不开启
        /// 
        /// 当设置为`true`时，可配合`AutoHandleUnsupportedElementTypes`参数使用，具体有哪些不兼容元素类型，可参考`AutoHandleUnsupportedElementTypes`参数的说明。
        /// </summary>
        [JsonProperty("AutoHandleUnsupportedElement")]
        public bool? AutoHandleUnsupportedElement{ get; set; }

        /// <summary>
        /// 此参数仅在`AutoHandleUnsupportedElement`参数为`true`的情况下有效。
        /// 
        /// 指定需要自动处理的不兼容元素类型，默认对所有不兼容的元素进行自动处理。
        /// 
        /// 目前支持检测的不兼容元素类型及对应的自动处理方式如下：
        /// 0: 不支持的墨迹类型
        /// -- 自动处理方式：移除墨迹
        /// 
        /// 1: 自动翻页
        /// -- 自动处理方式：移除自动翻页设置，并修改为单击切换
        /// 
        /// 2: 已损坏音视频
        /// -- 自动处理方式：移除对损坏音视频的引用
        /// 
        /// 3: 不可访问资源
        /// -- 自动处理方式：移除对不可访问的资源的引用
        /// 
        /// 4: 只读文件
        /// -- 自动处理方式：移除只读设置
        /// 
        /// 5: 不支持的元素编辑锁定状态
        /// -- 自动处理方式：移除锁定状态
        /// 
        /// 6: 可能有兼容问题的字体
        /// -- 自动处理方式： 不支持处理
        /// 
        /// 7: 设置了柔化边缘的GIF图片
        /// -- 自动处理方式：移除柔化边缘设置
        /// 
        /// 8: 存在不兼容的空格下划线
        /// -- 自动处理方式：通过调整空格下划线前后文本的字体语言体系，保证空格下划线表现正常
        /// 
        /// 9: 存在设置了分段动画的数学公式和文本混合内容
        /// -- 自动处理方式： 不支持处理
        /// 
        /// 10: 存在设置了分段动画的渐变色文本
        /// -- 自动处理方式： 不支持处理
        /// 
        /// 11: 存在不兼容的分散对齐方式
        /// -- 自动处理方式： 不支持处理
        /// 
        /// 12: 存在不兼容的多倍行距设置
        /// -- 自动处理方式： 不支持处理
        /// </summary>
        [JsonProperty("AutoHandleUnsupportedElementTypes")]
        public long?[] AutoHandleUnsupportedElementTypes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "AutoHandleUnsupportedElement", this.AutoHandleUnsupportedElement);
            this.SetParamArraySimple(map, prefix + "AutoHandleUnsupportedElementTypes.", this.AutoHandleUnsupportedElementTypes);
        }
    }
}

